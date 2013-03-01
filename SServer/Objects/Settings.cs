using System;
using System.Collections.Generic;
using System.Text;
using SServer.IO;

namespace SServer.Objects
{
    public struct Settings
    {
        public String[] multiplayer_Sysops;
        public Char[] login_Channel;     
        public Int32 gameParms_TimeLimit;
        public Int32 gameparms_ScoreLimit;
        public Int32 gameparms_LifeLimit;
        public Int32 gameparms_CaptureTheFlag;
        public Int32 gameparms_NumCTFStructures;
        public Int32 gameparms_AIUnitsPer10min;
        public Int32 gameparms_MaxAIUnits;
        public Int32 gameparms_AIBuildingsPer10min;
        public Int32 gameparms_MaxAIBuildings;
        public Int32 gameparms_IsMaxNumAIsScaled;
        public Int32 gameparms_NoReshroud;
        public Int32 gameparms_IsLadderGame;
        public Int32 gameparms_IsCrates;
        public Int32 gameparms_ResetTeamsInCTF;
        public Int32 gameparms_AllowFlagSitting;
        public Int32 gameparms_HealthBars;
        public Int32 gameparms_FreeRadarForAll;
        public Int32 gameparms_LosePowerups;
        public Int32 gameparms_Football;
        public Int32 gameparms_FootballNumFlags;
        public Int32 gameparms_MinPlayers;
        public Int32 gameparms_IonCannon;
        public Int32 gameparms_TeamCrates;
        public Int32 gameparms_SuperSeconds;
        public Int32 gameparms_ArmageddonTimer;
        public Int32 gameparms_SuperInvuln;
        public Int32 gameparms_NumTeams;
        public Int32 gameparms_PlayersPerTeam;
        public Int32 gameparms_AllowNoTeam;
        public Int32 gameparms_AllowPickTeam;
        public Int32 gameparms_IsSquadChannel;
        public Int32 gameparms_PasswordCountdownSeconds;
        public Int32 gameparms_IsAutoTeaming;
        public Int32 gameparms_RandomMaps;
        public Int32 crates_Steel;
        public Int32 crates_Green;
        public Int32 crates_Orange;
        public Int32[] weapons_Damage;
        public Int32[] weapons_Rof;
        public Int32[] weapons_Range;
        public Int32 stats_StatsInterval;
        public Int32 stats_ClientStats;
        public String stats_StatsFile;
        public Int32 stats_StatsAppend;

        public Settings(String Filename)
        {
            IniFile tempIniFile = new IniFile(Filename);
            IniFile.Section tempSection = tempIniFile.GetSection("[Multiplayer]");
            multiplayer_Sysops = new String[tempSection.GetProperties().Count];
            for (Int32 i = 0; i < multiplayer_Sysops.Length; i++)
            {
                multiplayer_Sysops[i] = tempSection.GetPropertyByName("Sysop"+i).GetValue()[0];
            }
            tempSection = tempIniFile.GetSection("[Login]");
            login_Channel = new Char[Environment.Variables.CHANNEL_NAME_LENGTH];
            Char[] tempchannelname = tempSection.GetPropertyByName("Channel").GetValue()[0].ToCharArray();
            if (tempchannelname.Length <= 80)
            {
                for (Int32 i = 0; i < tempchannelname.Length; i++)
                {
                    login_Channel[i] = tempchannelname[i];
                }
            }
            tempSection = tempIniFile.GetSection("[GameParms]");
            gameParms_TimeLimit = Int32.Parse(tempSection.GetPropertyByName("TimeLimit").GetValue()[0]);
            gameparms_ScoreLimit = Int32.Parse(tempSection.GetPropertyByName("ScoreLimit").GetValue()[0]);
            gameparms_LifeLimit = Int32.Parse(tempSection.GetPropertyByName("LifeLimit").GetValue()[0]);
            gameparms_CaptureTheFlag = Int32.Parse(tempSection.GetPropertyByName("CaptureTheFlag").GetValue()[0]);
            gameparms_NumCTFStructures = Int32.Parse(tempSection.GetPropertyByName("NumCTFStructures").GetValue()[0]);
            gameparms_AIUnitsPer10min = Int32.Parse(tempSection.GetPropertyByName("AIUnitsPer10min").GetValue()[0]);
            gameparms_MaxAIUnits = Int32.Parse(tempSection.GetPropertyByName("MaxAIUnits").GetValue()[0]);
            gameparms_AIBuildingsPer10min = Int32.Parse(tempSection.GetPropertyByName("AIBuildingsPer10min").GetValue()[0]);
            gameparms_MaxAIBuildings = Int32.Parse(tempSection.GetPropertyByName("MaxAIBuildings").GetValue()[0]);
            gameparms_IsMaxNumAIsScaled = Int32.Parse(tempSection.GetPropertyByName("IsMaxNumAIsScaled").GetValue()[0]);
            gameparms_NoReshroud = Int32.Parse(tempSection.GetPropertyByName("NoReshroud").GetValue()[0]);
            gameparms_IsLadderGame = Int32.Parse(tempSection.GetPropertyByName("IsLadderGame").GetValue()[0]);
            gameparms_IsCrates = Int32.Parse(tempSection.GetPropertyByName("IsCrates").GetValue()[0]);
            gameparms_ResetTeamsInCTF = Int32.Parse(tempSection.GetPropertyByName("ResetTeamsInCTF").GetValue()[0]);
            gameparms_AllowFlagSitting = Int32.Parse(tempSection.GetPropertyByName("AllowFlagSitting").GetValue()[0]);
            gameparms_HealthBars = Int32.Parse(tempSection.GetPropertyByName("HealthBars").GetValue()[0]);
            gameparms_FreeRadarForAll = Int32.Parse(tempSection.GetPropertyByName("FreeRadarForAll").GetValue()[0]);
            gameparms_LosePowerups = Int32.Parse(tempSection.GetPropertyByName("LosePowerups").GetValue()[0]);
            gameparms_Football = Int32.Parse(tempSection.GetPropertyByName("Football").GetValue()[0]);
            gameparms_FootballNumFlags = Int32.Parse(tempSection.GetPropertyByName("FootballNumFlags").GetValue()[0]);
            gameparms_MinPlayers = Int32.Parse(tempSection.GetPropertyByName("MinPlayers").GetValue()[0]);
            gameparms_IonCannon = Int32.Parse(tempSection.GetPropertyByName("IonCannon").GetValue()[0]);
            gameparms_TeamCrates = Int32.Parse(tempSection.GetPropertyByName("TeamCrates").GetValue()[0]);
            gameparms_SuperSeconds = Int32.Parse(tempSection.GetPropertyByName("SuperSeconds").GetValue()[0]);
            gameparms_ArmageddonTimer = Int32.Parse(tempSection.GetPropertyByName("ArmageddonTimer").GetValue()[0]);
            gameparms_SuperInvuln = Int32.Parse(tempSection.GetPropertyByName("SuperInvuln").GetValue()[0]);
            gameparms_NumTeams = Int32.Parse(tempSection.GetPropertyByName("NumTeams").GetValue()[0]);
            gameparms_PlayersPerTeam = Int32.Parse(tempSection.GetPropertyByName("PlayersPerTeam").GetValue()[0]);
            gameparms_AllowNoTeam = Int32.Parse(tempSection.GetPropertyByName("AllowNoTeam").GetValue()[0]);
            gameparms_AllowPickTeam = Int32.Parse(tempSection.GetPropertyByName("AllowPickTeam").GetValue()[0]);
            gameparms_IsSquadChannel = Int32.Parse(tempSection.GetPropertyByName("IsSquadChannel").GetValue()[0]);
            gameparms_PasswordCountdownSeconds = Int32.Parse(tempSection.GetPropertyByName("PasswordCountdownSeconds").GetValue()[0]);
            gameparms_IsAutoTeaming = Int32.Parse(tempSection.GetPropertyByName("IsAutoTeaming").GetValue()[0]);
            gameparms_RandomMaps = Int32.Parse(tempSection.GetPropertyByName("RandomMaps").GetValue()[0]);
            tempSection = tempIniFile.GetSection("[Crates]");
            crates_Steel = Int32.Parse(tempSection.GetPropertyByName("Steel").GetValue()[0]);
            crates_Green = Int32.Parse(tempSection.GetPropertyByName("Green").GetValue()[0]);
            crates_Orange = Int32.Parse(tempSection.GetPropertyByName("Orange").GetValue()[0]);
            tempSection = tempIniFile.GetSection("[Weapons]");
            weapons_Damage = new Int32[25];
            weapons_Rof = new Int32[25];
            weapons_Range = new Int32[25];
            for (int i = 0; i < weapons_Damage.Length; i++)
            {
                if (i < 10)
                {
                    weapons_Damage[i] = Int32.Parse(tempSection.GetPropertyByName("WEAPON_0" + i + "_DAMAGE").GetValue()[0]);
                }
                else
                {
                    weapons_Damage[i] = Int32.Parse(tempSection.GetPropertyByName("WEAPON_" + i + "_DAMAGE").GetValue()[0]);
                }
            }
            for (int i = 0; i < weapons_Rof.Length; i++)
            {
                if (i < 10)
                {
                    weapons_Rof[i] = Int32.Parse(tempSection.GetPropertyByName("WEAPON_0" + i + "_ROF").GetValue()[0]);
                }
                else
                {
                    weapons_Rof[i] = Int32.Parse(tempSection.GetPropertyByName("WEAPON_" + i + "_ROF").GetValue()[0]);
                }
            }
            for (int i = 0; i < weapons_Range.Length; i++)
            {
                if (i < 10)
                {
                    weapons_Range[i] = Int32.Parse(tempSection.GetPropertyByName("WEAPON_0" + i + "_RANGE").GetValue()[0]);
                }
                else
                {
                    weapons_Range[i] = Int32.Parse(tempSection.GetPropertyByName("WEAPON_" + i + "_RANGE").GetValue()[0]);
                }
            }
            tempSection = tempIniFile.GetSection("[Stats]");
            stats_StatsInterval = Int32.Parse(tempSection.GetPropertyByName("StatsInterval").GetValue()[0]);
            stats_ClientStats = Int32.Parse(tempSection.GetPropertyByName("ClientStats").GetValue()[0]);
            stats_StatsFile = tempSection.GetPropertyByName("StatsFile").GetValue()[0];
            stats_StatsAppend = Int32.Parse(tempSection.GetPropertyByName("StatsAppend").GetValue()[0]);
        }
    }
}
