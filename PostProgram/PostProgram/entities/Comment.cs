﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PostProgram.entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {

        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
