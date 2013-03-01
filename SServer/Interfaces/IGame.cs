using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Interfaces
{
    public interface IGame
    {
        // Basic events to perform on Clients
        void Pause();
        void Resume();
        void Kick();
        void Ban();
        // ~30? game events to send to client
        /*
        void EventZero();
        void EventOne();
        void PlayerLeave();
        void EventThree();
        void SendGameSettings();
        void EventFive();
        void EventSix();
        void InitialGameStateStart();
        void InitialGameStateInfo();
        void InitialGameStateStop();
        void EventTen();
        void EventEleven();
        void EventTwelve();
        void EventThirteen();
        void Kill();
        void EventFifteen();
        void EventSixteen();
        void GiveFlag();
        void EventEightteen();
        void EventNineteen();
        void EventTwenty();
        void EventTwentyOne();
        void EventTwentyTwo();
        void EventTwentyThree();
        void GetCrate();
        void EventTwentyFive();
        void Spectate();
        void EndGame();
        void ChangeMap();
        void Message();
        void SendPassword();
         */
    }
}
