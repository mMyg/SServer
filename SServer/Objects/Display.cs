using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using SServer.Database;
using SServer.IO;
using SServer.Enums;

namespace SServer.Objects
{
    public class Display
    {
        private Bitmap _currentbitmap;
        private Cell[] _currentcells;
        private Cell[] _previouscells;
        private Templates _templates;
        private MixFile _temperat;
        private MixFile _desert;
        private MixFile _winter;

        public Display()
        {
            _currentbitmap = new Bitmap(Environment.Variables.MAP_PIXEL_DIMENSION,Environment.Variables.MAP_PIXEL_DIMENSION);
            _templates = new Templates();
            _temperat = new MixFile("temperat.mix");
            _desert = new MixFile("desert.mix");
            _winter = new MixFile("winter.mix");
        }

        public void Load(Cell[] Cells)
        {
            _previouscells = _currentcells;
            _currentcells = Cells;
        }

        public Boolean Draw()
        {
            if (_currentcells == null)
            {
                return false;
            }
            else
            {
                for (Int16 i = 0; i < _currentcells.Length; i++)
                {
                    Template currentcelltemplate = _currentcells[i].GetTemplate();
                    if (currentcelltemplate != null)
                    {
                        String currenttemplatename = _templates.GetNameById(currentcelltemplate.GetId());
                        Byte[] currenttemplatebytes = new Byte[0];
                        switch (_currentcells[i].GetTheater())
                        {
                            case Theater.TEMPERATE:
                                currenttemplatename += Environment.Variables.TEMPERATE_TEMPLATE_ID;
                                TemplateFile currenttemperatetemplate = new TemplateFile(_temperat.GetFileByString(currenttemplatename));
                                currenttemplatebytes = currenttemperatetemplate.GetTileData(currentcelltemplate.GetTile());
                                break;
                            case Theater.DESERT:
                                currenttemplatename += Environment.Variables.DESERT_TEMPLATE_ID;
                                TemplateFile currentdeserttemplate = new TemplateFile(_desert.GetFileByString(currenttemplatename));
                                currenttemplatebytes = currentdeserttemplate.GetTileData(currentcelltemplate.GetTile());
                                break;
                            case Theater.WINTER:
                                currenttemplatename += Environment.Variables.WINTER_TEMPLATE_ID;
                                TemplateFile currentwintertemplate = new TemplateFile(_winter.GetFileByString(currenttemplatename));
                                currenttemplatebytes = currentwintertemplate.GetTileData(currentcelltemplate.GetTile());
                                break;
                        }
                        if (currenttemplatebytes.Length > 0)
                        {
                            // Load template pallete and convert

                            // Place converted colour into proper pixel location
                            for (Int16 j = 0; j < currenttemplatebytes.Length; j++)
                            {

                            }
                        }
                    }
                }
                return true;
            }
        }

        public void Clear()
        {
            _currentbitmap = new Bitmap(Environment.Variables.MAP_PIXEL_DIMENSION, Environment.Variables.MAP_PIXEL_DIMENSION);
            _currentcells = null;
            _previouscells = null;
        }
    }
}
