using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SServer.IO
{
    public class IniFile
    {
        enum ParseState
        {
            None,
            COMMENT,
            SECTION,
            PROPERTY
        }

        public class Comment
        {
            private String _comment;

            public Comment(String Comment)
            {
                _comment = Comment;
            }

            public String GetComment()
            {
                return _comment;
            }

            public override String ToString()
            {
                return _comment;
            }
        }

        public class Property
        {
            private String _name;
            private String[] _value;

            public Property(String Name, String[] Value)
            {
                _name = Name;
                _value = Value;
            }

            public void SetName(String Name)
            {
                _name = Name;
            }

            public void SetValue(String[] Value)
            {
                _value = Value;
            }

            public String GetName()
            {
                return _name;
            }

            public String[] GetValue()
            {
                return _value;
            }

            public override String ToString()
            {
                String tempReturn = String.Empty;
                if (_value.Length == 1 && _value.Length != 0)
                {
                    tempReturn = _name + "=" + _value[0];
                }
                else
                {
                    tempReturn = _name + "=" + _value[0];
                    foreach(String a in _value)
                    {
                        tempReturn += ("," + a);
                    }
                }
                return tempReturn;
            }
        }

        public class Section
        {
            private String _name;
            private List<Property> _properties;

            public Section(String Name)
            {
                _properties = new List<Property>();
                _name = Name;
            }
            
            public void AddProperty(Property P)
            {
                _properties.Add(P);
            }

            public void RemoveProperty(Property P)
            {
                _properties.Remove(P);
            }

            public String GetName()
            {
                return _name;
            }

            public List<Property> GetProperties()
            {
                return _properties;
            }

            public Property GetPropertyByName(String Name)
            {
                foreach (Property a in _properties)
                {
                    if (a.GetName().ToLower() == Name.ToLower())
                    {
                        return a;
                    }
                }
                return null;
            }

            public void Clear()
            {
                _properties.Clear();
            }

            public override String ToString()
            {
                String tempReturn = String.Empty;
                tempReturn += _name + System.Environment.NewLine;
                foreach (Property a in _properties)
                {
                    tempReturn += a.ToString() + System.Environment.NewLine;
                }
                tempReturn += System.Environment.NewLine;
                return tempReturn;
            }
        }

        protected List<Comment> _comments;
        protected List<Property> _properties;
        protected List<Section> _sections;

        private String _iniString;
        private String _path;

        public IniFile(String Path)
        {
            _path = Path;
            _comments = new List<Comment>();
            _properties = new List<Property>();
            _sections = new List<Section>();
            _iniString = String.Empty;
            StreamReader streamReader = new StreamReader(Path);
            _iniString = streamReader.ReadToEnd();
            streamReader.Close();
            parse();
        }

        public IniFile(Byte[] Data)
        {
            _path = String.Empty;
            _comments = new List<Comment>();
            _properties = new List<Property>();
            _sections = new List<Section>();
            _iniString = String.Empty;
            _iniString = System.Text.ASCIIEncoding.ASCII.GetString(Data);
            parse();
        }

        public void Read(String Path)
        {
            _path = Path;
            _iniString = String.Empty;
            StreamReader streamReader = new StreamReader(Path);
            _iniString = streamReader.ReadToEnd();
            streamReader.Close();
            parse();
        }

        public void Write()
        {
            StreamWriter outfile = new StreamWriter(_path, false);
            String tempOutfile = String.Empty;
            foreach (Section a in _sections)
            {
                tempOutfile += a.ToString();
            }
            outfile.Write(tempOutfile);
            outfile.Close();
        }

        public Section GetSection(String Name)
        {
            foreach (Section a in _sections)
            {
                if (a.GetName().ToLower() == Name.ToLower())
                {
                    return a;
                }
            }
            return null;
        }

        private void parse()
        {
            String[] tempSplitIniString = _iniString.Split(new char[] { '\n' });
            ParseState tempParseState = ParseState.None;
            Section tempCurrentSection = null; ;
            foreach (String a in tempSplitIniString)
            {
                if (a.Contains("="))
                {
                    tempParseState = ParseState.PROPERTY;
                }
                else
                {
                    if (a.Length > 0)
                    {
                        Char tempFirstChar = a[0];
                        switch (tempFirstChar)
                        {
                            case ';':
                                tempParseState = ParseState.COMMENT;
                                break;
                            case '[':
                                tempParseState = ParseState.SECTION;
                                break;
                        }
                    }
                }

                switch (tempParseState)
                {
                    case ParseState.COMMENT:
                        _comments.Add(new Comment(a));
                        break;
                    case ParseState.PROPERTY:
                        if (tempCurrentSection != null)
                        {
                            String[] tempPropertyStrings = a.Split(new char[] { '=' });
                            if (a.Length > 1)
                            {
                                String[] tempPropertyValues = tempPropertyStrings[1].Split(new char[] { ',' });
                                tempCurrentSection.AddProperty(new Property(tempPropertyStrings[0], tempPropertyValues));
                            }
                        }
                        break;
                    case ParseState.SECTION:
                        String tempSectionName = a.Trim(new char[]{'\n', '\t'});
                        tempCurrentSection = new Section(tempSectionName.Trim());
                        _sections.Add(tempCurrentSection);
                        break;
                }
            }
        }
    }
}
