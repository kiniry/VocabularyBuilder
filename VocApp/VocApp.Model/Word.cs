﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocApp.Model {
    public class Word {

        public string Wordstring {
            get;
            private set;
        }

        public int Rating {
            get; 
            set;
        }

        public Word(string Wordstring) {
            this.Wordstring = Wordstring;
            this.Rating = 3;
        }

        public override bool Equals(object obj) {
            if (obj is Word) {
                return Wordstring == (obj as Word).Wordstring;
            }
            return false;
        }

        public override int GetHashCode() {
            return Wordstring.GetHashCode();
        }
    }
}
