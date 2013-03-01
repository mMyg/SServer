using System;
using System.Collections.Generic;
using System.Text;
using SServer.Objects;

namespace SServer.Packets
{
    public class GameInfo : SSPacket
    {
        public GameInfo(Unit Unit, Scenario Map, Game Game, Settings GameSettings)
        {
            // Player specific options/etc
            EndAddByte(4);
            //private Byte House (defined in scenario.ini, Similar to Side 6-9 for team, 10-100 for deathmatch)
            EndAddByte(Unit.GetUnitSlot());
            //private Byte Side
            EndAddByte(Unit.GetHouse());
            //private Int32 allowVoiceThemes;
            EndAddInt32(0); // PROBLEM OFFICER?
            //private Byte scenario;
            EndAddByte((Byte)Map._scenarionumber);
            //private Int32 unkA;
            EndAddInt32(500); // Timeout? 500
            //private Int32 unkE;
            EndAddInt32(4);  // Game speed? 4
            //private Byte unk12;
            EndAddByte(7); // ? 7 
            //private Byte unk13;
            EndAddByte(1); // ?? 1
            //private Int32 various_flags;
            EndAddInt32(32); // Spectator? (can see all health bars when first bit enabled) 32
            // Game Setting options
            //private Int32 TimeLimit;
            EndAddInt32(GameSettings.gameParms_TimeLimit);
            //private Int32 ScoreLimit;
            EndAddInt32(GameSettings.gameparms_ScoreLimit);
            //private Int32 LifeLimit;
            EndAddInt32(GameSettings.gameparms_LifeLimit);
            //private Int32 CaptureTheFlag;
            EndAddInt32(GameSettings.gameparms_CaptureTheFlag);
            //private Int32 Football;
            EndAddInt32(GameSettings.gameparms_Football);
            //private Int32 FootballNumFlags;
            EndAddInt32(GameSettings.gameparms_FootballNumFlags);
            //private Int32 NumCTFStructures;
            EndAddInt32(GameSettings.gameparms_NumCTFStructures);
            //private Int32 unk;
            EndAddInt32(0);
            //private Int32 AIUnitsPer10Min;
            EndAddInt32(GameSettings.gameparms_AIUnitsPer10min);
            //private Int32 MaxAIUnits;
            EndAddInt32(GameSettings.gameparms_MaxAIUnits);
            //private Int32 AIBuildingsPer10Min;
            EndAddInt32(GameSettings.gameparms_AIBuildingsPer10min);
            //private Int32 MaxAIBuildings;
            EndAddInt32(GameSettings.gameparms_MaxAIBuildings);
            //private Int32 IsMaxNumAIsScaled;
            EndAddInt32(GameSettings.gameparms_IsMaxNumAIsScaled);
            //private Int32 ResetTeamsInCTF;
            EndAddInt32(GameSettings.gameparms_ResetTeamsInCTF);
            //private Int32 AllowFlagSitting;
            EndAddInt32(GameSettings.gameparms_AllowFlagSitting);
            //private Int32 HealthBars;
            EndAddInt32(GameSettings.gameparms_HealthBars);
            //private Int32 FreeRadarForAll;
            EndAddInt32(GameSettings.gameparms_FreeRadarForAll);
            //private Int32 LosePowerups;
            EndAddInt32(GameSettings.gameparms_LosePowerups);
            //private Int32 MinPlayers;
            EndAddInt32(GameSettings.gameparms_MinPlayers);
            //private Int32 IonCannon;
            EndAddInt32(GameSettings.gameparms_IonCannon);
            //private Int32 TeamCrates;
            EndAddInt32(GameSettings.gameparms_TeamCrates);
            //private Int32 SuperSeconds;
            EndAddInt32(GameSettings.gameparms_SuperSeconds);
            //private Int32 ArmageddonTimer;
            EndAddInt32(GameSettings.gameparms_ArmageddonTimer);
            //private Int32 bitfield;
            Int32 BitFieldValue = 0;
            if (GameSettings.gameparms_NoReshroud == 1)
            {
                BitFieldValue |= 2;
            }
            if (GameSettings.gameparms_IsLadderGame == 1)
            {
                BitFieldValue |= 4;
            }
            if (GameSettings.gameparms_IsCrates == 1)
            {
                BitFieldValue |= 8;
            }
            EndAddInt32(BitFieldValue);
            //private Int32 SteelCrates;
            EndAddInt32(GameSettings.crates_Steel);
            //private Int32 GreenCrates;
            EndAddInt32(GameSettings.crates_Green);
            //private Int32 OrangeCrates;
            EndAddInt32(GameSettings.crates_Orange);
            //private Int32 IsSquadChannel;
            EndAddInt32(GameSettings.gameparms_IsSquadChannel);
            //private Int32 PasswordCountdownSeconds;
            EndAddInt32(GameSettings.gameparms_PasswordCountdownSeconds);
            //private Int32 NumTeams;
            EndAddInt32(GameSettings.gameparms_NumTeams);
            //private Int32 PlayersPerTeam;
            EndAddInt32(GameSettings.gameparms_PlayersPerTeam);
            //private Int32 AllowNoTeam;
            EndAddInt32(GameSettings.gameparms_AllowNoTeam);
            //private Int32 AllowPickTeam;
            EndAddInt32(GameSettings.gameparms_AllowPickTeam);
            //private Char[] Channel = new Char[80];
            EndAddChars(GameSettings.login_Channel);// TODO: FIX THIS
            //private Int32 CrateDensityOverride;
            EndAddInt32(0); // TODO: FIND AND FIX THIS VARIABLE
            //private Int32 IsAutoTeaming;
            EndAddInt32(GameSettings.gameparms_IsAutoTeaming);
            //private Int32 SuperInvuln;
            EndAddInt32(GameSettings.gameparms_SuperInvuln);
            // Team and  Damage info
            //private Int32 unkF8; 
            EndAddInt32(0);
            //private Int32 unkFC;
            EndAddInt32(0); // Squad channel?
            //private Int32[] team_scores = new Int32[4];
            for (Int32 i = 0; i < 4; i++)
            {
                EndAddInt32(0);
            }
            //private Byte[] weapon_damages = new Byte[25];
            for (Byte i = 0; i < 25; i++)
            {
                EndAddByte((Byte)GameSettings.weapons_Damage[i]);
            }
            //private Byte[] weapon_rofs = new Byte[25];
            for (Byte i = 0; i < 25; i++)
            {
                EndAddByte((Byte)GameSettings.weapons_Rof[i]);
            }
            //private Int32[] weapon_ranges = new Int32[25];
            for (Int32 i = 0; i < 25; i++)
            {
                EndAddInt32(GameSettings.weapons_Range[i]);
            }
            StartAddInt16((short)(_data.Count + 2));
        }
    }
   
}
