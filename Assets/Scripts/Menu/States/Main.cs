﻿using System;
using System.Collections;
using UnityEngine;


namespace HistoryHex {
    namespace MenuStates {
        public class Main : MBState {

            public MBState options;
            public MBState credits;

            public GameObject mainMenu;

            private Action<IState> changeState;

            public void OnStartPressed() {
                // TODO: Application.LoadScene()
            }

            public void OnCreditsPressed() {
                changeState(options);
            }

            public void OnOptionsPressed() {
                changeState(credits);
            }

            public override void Enter(IState previousState) {
                mainMenu.SetActive(true);
            }

            public override void Execute(Action<IState> changeState) {
                this.changeState = changeState;
            }

            public override void Exit() {
                mainMenu.SetActive(false);
            }
        }
    }
}