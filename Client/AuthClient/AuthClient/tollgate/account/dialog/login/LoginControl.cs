﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AuthClient.tollgate.account.dialog
{
    public partial class LoginControl : UserControl
    {
        [Category("Tollgate")]
        public event EventHandler LoginButtonClick
        {
            add { btn_login.Click += value; }
            remove { btn_login.Click -= value; }
        }

        [Category("Tollgate")]
        public event EventHandler SignupButtonClick
        {
            add { img_title.SignupButtonClick += value; }
            remove { img_title.SignupButtonClick -= value; }
        }

        [Category("Tollgate")]
        public event KeyEventHandler PwdKeyDown
        {
            add { text_pwd.KeyDown += value; }
            remove { text_pwd.KeyDown -= value; }
        }

        [Category("Tollgate")]
        public string ID
        {
            get { return text_id.Text; }
            set { text_id.Text = value; }
        }

        [Category("Tollgate")]
        public string PWD
        {
            get { return text_pwd.Text; }
            set { text_pwd.Text = value; }
        }

        [Category("Tollgate")]
        public bool FixID
        {
            get { return text_id.Enabled; }
            set { text_id.Enabled = value; }
        }

        [Category("Tollgate")]
        public bool RegisteredUserExist
        {
            get { return registeredUserExist; }
            set
            {
                img_title.CanSignup = !value;
                registeredUserExist = value;
            }
        }
        private bool registeredUserExist = false;

        public LoginControl()
        {
            InitializeComponent();
        }
    }
}
