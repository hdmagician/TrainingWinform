﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BikeShop
{
    public class Human
    {
        public string FirstName { get; set; }
        public bool HasDrivingLicense { get; set; }
    }
    public class Car : Notifier
    {
        private double speed;
        public double Speed
        {
            get { return speed; }
            set {
                speed = value;
                OnPropertyChanged("Speed"); // 속성값이 변경되는 것을 클라이언트 시스템에 통보해줌
            }
        }

        public Color Color { get; set; } // 속성은 모두 겟셋을 가진다.
        public Human Driver { get; set; }
        
    }
}
