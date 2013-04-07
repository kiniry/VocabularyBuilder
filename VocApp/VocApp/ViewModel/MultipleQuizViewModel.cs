﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using VocApp.View;
using VocApp.Model;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace VocApp.ViewModel {
    public class MultipleQuizViewModel : ViewModelBase {

        internal MainViewModel mvm;

        private string ans1;
        public string Ans1 {
            get {
                return ans1;
            }
            set {
                ans1 = value;
            }
        }
        private string ans2;
        public string Ans2 {
            get {
                return ans2;
            }
            set {
                ans2 = value;
            }
        }
        private string ans3;
        public string Ans3 {
            get {
                return ans3;
            }
            set {
                ans3 = value;
            }
        }
        private string ans4;
        public string Ans4 {
            get {
                return ans4;
            }
            set {
                ans4 = value;
            }
        }
        private string ans5;
        public string Ans5 {
            get {
                return ans5;
            }
            set {
                ans5 = value;
            }
        }
        private string text;
        public string Text {
            get {
                return text;
            }
            set {
                text = value;
                RaisePropertyChanged("Text");
            }
        }
        private string vis;
        public string Vis {
            get {
                return vis;
            }
            set {
                vis = value;
                RaisePropertyChanged("Vis");
            }
        }
        private string visW;
        public string VisW {
            get {
                return visW;
            }
            set {
                visW = value;
                RaisePropertyChanged("VisW");
            }
        }
        MultipleQuiz Quiz;
        public bool Complete = false;
        public ICommand Ans1Command { get; private set; }
        public ICommand Ans2Command { get; private set; }
        public ICommand Ans3Command { get; private set; }
        public ICommand Ans4Command { get; private set; }
        public ICommand Ans5Command { get; private set; }
        public ICommand NewQuizCommand { get; private set; }

        public MultipleQuizViewModel(MainViewModel mvm) {
            this.vis = "Hidden";
            this.visW = "Hidden";
            this.mvm = mvm;
            this.Quiz = mvm.model.GenerateQuiz() as MultipleQuiz;
            string[] words = Quiz.AllAnswers;
            text = Quiz.word.Wordstring;
            ans1 = words[0];
            ans2 = words[1];
            ans3 = words[2];
            ans4 = words[3];
            ans5 = words[4];
            Ans1Command = new RelayCommand(Answer1);
            Ans2Command = new RelayCommand(Answer2);
            Ans3Command = new RelayCommand(Answer3);
            Ans4Command = new RelayCommand(Answer4);
            Ans5Command = new RelayCommand(Answer5);
            NewQuizCommand = new RelayCommand(NewQuiz, CanNewQuiz);
        }

        public void Answer1() {
            Quiz.Attempts = Quiz.Attempts + 1;
            if (Quiz.ansIndex == 0) {
                ResetIcons();
                Vis = "Visible";
                Complete = true;
            }
            else {
                ResetIcons();
                VisW = "Visible";
            }
        }

        public void Answer2() {
            Quiz.Attempts = Quiz.Attempts + 1;
            if (Quiz.ansIndex == 1) {
                ResetIcons();
                Vis = "Visible";
                Complete = true;
            }
            else {
                ResetIcons();
                VisW = "Visible";
            }
        }

        public void Answer3() {
            Quiz.Attempts = Quiz.Attempts + 1;
            if (Quiz.ansIndex == 2) {
                ResetIcons();
                Vis = "Visible";
                Complete = true;
            }
            else {
                ResetIcons();
                VisW = "Visible";
            }
        }

        public void Answer4() {
            Quiz.Attempts = Quiz.Attempts + 1;
            if (Quiz.ansIndex == 3) {
                ResetIcons();
                Vis = "Visible";
                Complete = true;
            }
            else {
                ResetIcons();
                VisW = "Visible";
            }
        }

        public void Answer5() {
            Quiz.Attempts = Quiz.Attempts + 1;
            if (Quiz.ansIndex == 4) {
                ResetIcons();
                Vis = "Visible";
                Complete = true;
            }
            else {
                ResetIcons();
                VisW = "Visible";
            }
        }

        public void ResetIcons() {
            Vis = "Hidden";
            VisW = "Hidden";
        }

        public void NewQuiz() {
            if (mvm.model.Session.Count < 10) {
                MultipleQuizWindow newWindow = new MultipleQuizWindow(mvm);
                newWindow.Show();
            } 
        }

        public bool CanNewQuiz() {
            return Complete;
        }
    }
}