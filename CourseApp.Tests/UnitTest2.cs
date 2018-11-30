using System;
using CourseApp;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test6()
        {
            Television tv = new Television();
            var Channel = tv.channel;
            var Model = tv.model;
            var Age = tv.age;
            Assert.Equal(1, Channel);
            Assert.Equal(1, Model);
            Assert.Equal(0, Age);
        }
        [Fact]
        public void Test7()
        {
            Television tv = new Television(100);
            var Channel = tv.channel;
            var Model = tv.model;
            var Age = tv.age;
            Assert.Equal(100, Channel);
            Assert.Equal(1, Model);
            Assert.Equal(3, Age);
        }
        [Fact]
        public void Test8()
        {
            Television tv = new Television(50);
            var Channel = tv.channel;
            var Model = tv.model;
            var Age = tv.age;
            Assert.Equal(50, Channel);
            Assert.Equal(2, Model);
            Assert.Equal(7, Age);
        }
        [Fact]
        public void Test9()
        {
            Television tv = new Television(7, 1, 6);
            var Channel = tv.channel;
            var Model = tv.model;
            var Age = tv.age;
            Assert.Equal(7, Channel);
            Assert.Equal(1, Model);
            Assert.Equal(6, Age);
        }
        [Fact]
        public void Test10()
        {
            Television tv = new Television(2, 2, 8);
            var Channel = tv.channel;
            var Model = tv.model;
            var Age = tv.age;
            string TV = tv.getInfo();
            string h = "";
            for (int i = 0; i < 3 - Channel.ToString().Length; i++) h += "░";
            Assert.Equal($"\nКанал: {Channel}, Модель телевизора: {Model}, Возвраст телевизора: {Age}\n ██████████░▀▀██████████████▀▀░██████████\n ████████████▄░▀▀████████▀▀░▄████████████\n ███████████████▄█▀▀▀▀▀▀█▄███████████████\n ████████████████▄▄▄▄▄▄▄▄████████████████\n ████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀████\n ███░░▄▄█████████████████████▄░░░▄▄░░░███\n ███░░█▀░Канал {Channel}{h}▄▄▄▄█████████░████░░███\n ███░░█░░░░░░░▄████████████████░░▀▀░░░███\n ███░░█░░░░▄███████████████████░░░░░░░███\n ███░░█░░░█████████████████████░░░░░░░███\n ███░░█░░██████████████████████░░░░░░░███\n ███░░█░███████████████████████░▀███░░███\n ███░░█████████████████████████░▄▄▄▄░░███\n ███░░█████████████████████████░▄▄▄▄░░███\n ███░░▀███████████████████████▀░░▀▀▀░░███\n ███▄░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▄███\n ████████████████████████████████████████", TV);
        }
        [Fact]
        public void Test11()
        {
            Television tv = new Television(2, 1, 8);
            var Channel = tv.channel;
            var Model = tv.model;
            var Age = tv.age;
            string TV = tv.getInfo();
            string h = "";
            for (int i = 0; i < 3 - Channel.ToString().Length; i++) h += "▒";
            Assert.Equal($"\nКанал: {Channel}, Модель телевизора: {Model}, Возвраст телевизора: {Age}\n ▄██████████████████████████████████████▄\n █▀─▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄─▀████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒Канал {Channel}{h}▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌█░░██░░█\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌█░░██░░█\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▄─▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀─▄████████\n ▀██████████████████████████████████████▀\n ───▄▄▄████████████████████████████▄▄▄\n ──████████████████████████████████████", TV);
        }
    }
}
