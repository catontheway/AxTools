﻿using System;
using System.Reflection;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Components
{
    public partial class MetroTextboxExt : MetroTextBox
    {
        private readonly TextBox internalTextBox;

        public MetroTextboxExt()
        {
            InitializeComponent();
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.NonPublic;
            Type baseType = GetType().BaseType;
            if (baseType != null)
            {
                FieldInfo field = baseType.GetField("baseTextBox", bindFlags);
                if (field != null)
                {
                    internalTextBox = (TextBox) field.GetValue(this);
                }
            }
        }

        public HorizontalAlignment TextAlign
        {
            get { return internalTextBox.TextAlign; }
            set { internalTextBox.TextAlign = value; }
        }

        public bool ReadOnly
        {
            get { return internalTextBox.ReadOnly; }
            set { internalTextBox.ReadOnly = value; }
        }

    }
}