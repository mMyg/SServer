using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Objects
{
    public class Vehicle
    {
        public Int32 _turnspeed;
        public Int32 _speed;
        public Int32 _movementtype;
        public Int32 _armour;
        public Int32 _secondaryweapon;
        public Int32 _primaryweapon;
        public Int32 _owner;
        public Int32 _buildatlevel;
        public Int32 _cost;
        public Int32 _sight;
        public Int32 _hitpoints;
        public Int32 _shotsbeforereload;
        public Int32 _cyclethroughgraphics;
        public Int32 _iscloaked;
        public Int32 _graphicscantturn; // What is this exactly?
        public Int32 _islargeunit;
        public Int32 _fixedturret;
        public Int32 _hasattackanimation;
        public Int32 _hasmovingturret;
        public Int32 _iscrewed;
        public Int32 _canbebuilt;
        public Int32 _firesburst;
        public Int32 _hasturret;
        public Int32 _isinvulnerable;
        public Int32 _harveststiberium;
        public Int32 _cancrush;
        public Int32 _canbecrushed;
        public Int32 _hastransportability;
        public Int32 _nameisshown;
        public Int32 _isdinosaur;
        public Int32 _prerequisites;
        public Int32 _techlevel;
        public Int32 _deathanimation;
        public String _namestring;
        public Int32 _namestringid;
        public Int32 _unitid;

        public Vehicle(Int32 turnspeed, Int32 speed, Int32 movementtype, Int32 armour, Int32 secondaryweapon, Int32 primaryweapon,
         Int32 owner, Int32 buildatlevel, Int32 cost, Int32 sight, Int32 hitpoints, Int32 shotsbeforereload, Int32 cyclethroughgraphics,
         Int32 iscloaked, Int32 graphicscantturn, Int32 islargeunit, Int32 fixedturret, Int32 hasattackanimation, Int32 hasmovingturret,
         Int32 iscrewed, Int32 canbebuilt, Int32 firesburst, Int32 hasturret, Int32 isinvulnerable, Int32 harveststiberium,
         Int32 cancrush, Int32 canbecrushed, Int32 hastransportability, Int32 nameisshown, Int32 isdinosaur, Int32 prerequisites,
         Int32 techlevel, Int32 deathanimation, String namestring, Int32 namestringid, Int32 unitid)
        {
            _turnspeed = turnspeed;
            _speed = speed;
            _movementtype = movementtype;
            _armour = armour;
            _secondaryweapon = secondaryweapon;
            _primaryweapon = primaryweapon;
            _owner = owner;
            _buildatlevel = buildatlevel;
            _cost = cost;
            _sight = sight;
            _hitpoints = hitpoints;
            _shotsbeforereload = shotsbeforereload;
            _cyclethroughgraphics = cyclethroughgraphics;
            _iscloaked = iscloaked;
            _graphicscantturn = graphicscantturn; // ?
            _islargeunit = islargeunit;
            _fixedturret = fixedturret;
            _hasattackanimation = hasattackanimation;
            _hasmovingturret = hasmovingturret;
            _iscrewed = iscrewed;
            _canbebuilt = canbebuilt;
            _firesburst = firesburst;
            _hasturret = hasturret;
            _isinvulnerable = isinvulnerable;
            _harveststiberium = harveststiberium;
            _cancrush = cancrush;
            _canbecrushed = canbecrushed;
            _hastransportability = hastransportability;
            _nameisshown = nameisshown;
            _isdinosaur = isdinosaur;
            _prerequisites = prerequisites;
            _techlevel = techlevel;
            _namestring = namestring;
            _deathanimation = deathanimation;
            _namestringid = namestringid;
            _unitid = unitid;
        }
    }
}
