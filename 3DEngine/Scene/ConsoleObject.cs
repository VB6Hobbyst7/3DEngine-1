﻿using System;
using System.Drawing;

namespace _3DEngine
{
    public class ConsoleObject : SceneObject
    {
        public double SecondDisplayDiagonal { get; set; } = 55;
        public double ManipulatorRadius { get; set; } = 3;
        public double ManipulatorBaseRadius { get; set; } = 5;
        public double CylindersHeight { get; set; } = 2.5;
        public double CylindersRadius { get; set; } = 2.5;
        public double CrossButtonSize { get; set; } = 5;
        public double VolumeSpace { get; set; } = 1;
        public double FrameThickness { get; set; } = 1;
        public double BrightnessBottomPosition { get; set; } = 15;
        public double CardReaderWidth { get; set; } = 15;
        public int CardReadersCount { get; set; } = 1;
        public int IndicatorsCount { get; set; } = 3;
        
        public ConsoleObject(string name) : base(name)
        {
            UpdateObject();
        }

        public void UpdateObject()
        {
            ScenePrimitives.Clear();

            ScenePrimitive fuselage = new ScenePrimitive(
                new Cylinder(new Point3D(-30, 0, 0), 10, 70, 16, Color.FromArgb(211, 211, 211)),
                "Фюзеляж"
                );
            fuselage.AngleZ = -90;
            ScenePrimitives.Add(fuselage);

            ScenePrimitive auxiliary1 = new ScenePrimitive(
                new Hemisphere(new Point3D(-100, 0, 0), 10, 16, Color.FromArgb(211, 211, 211)),
                "Вспомогательный1"
                );
            auxiliary1.AngleZ = -90;
            ScenePrimitives.Add(auxiliary1);

            ScenePrimitive wing1 = new ScenePrimitive(
                new Box(new Point3D(-91.5, 13, 0), 15, 2, 100, Color.FromArgb(211, 211, 211)),
                "Крыло1"
                );
            ScenePrimitives.Add(wing1);

            ScenePrimitive wing2 = new ScenePrimitive(
                new Box(new Point3D(-91, -10, 0), 15, 2, 100, Color.FromArgb(211, 211, 211)),
                "Крыло2"
                );
            ScenePrimitives.Add(wing2);

            ScenePrimitive wing3 = new ScenePrimitive(
                new Box(new Point3D(-91, 30, 0), 15, 2, 100, Color.FromArgb(211, 211, 211)),
                "Крыло3"
                );
            ScenePrimitives.Add(wing3);

            ScenePrimitive auxiliary2 = new ScenePrimitive(
                new Sphere(new Point3D(-108, 0, 0), 5, 16, Color.FromArgb(211, 211, 211)),
                "Вспомогательный2"
                );
            ScenePrimitives.Add(auxiliary2);

            ScenePrimitive screw = new ScenePrimitive(
                new Box(new Point3D(-109.5, -2, 0), 2, 5, 45, Color.FromArgb(211, 211, 211)),
                "Винт"
                );
            ScenePrimitives.Add(screw);

            ScenePrimitive support1 = new ScenePrimitive(
                new Box(new Point3D(-92, -9, -30), 2, 42, 2, Color.FromArgb(211, 211, 211)),
                "Поддержка1"
                );
            ScenePrimitives.Add(support1);

            ScenePrimitive support2 = new ScenePrimitive(
                new Box(new Point3D(-92, -9, 30), 2, 42, 2, Color.FromArgb(211, 211, 211)),
                "Поддержка2"
                );
            ScenePrimitives.Add(support2);

            ScenePrimitive support3 = new ScenePrimitive(
                new Box(new Point3D(-92, 6, -2.5), 2, 26, 2, Color.FromArgb(211, 211, 211)),
                "Поддержка3"
                );
            ScenePrimitives.Add(support3);

            ScenePrimitive support4 = new ScenePrimitive(
                new Box(new Point3D(-92, 6, 2.5), 2, 26, 2, Color.FromArgb(211, 211, 211)),
                "Поддержка4"
                );
            ScenePrimitives.Add(support4);

            ScenePrimitive bearingChassis1 = new ScenePrimitive(
                new Box(new Point3D(-94, -25, 5), 2, 17, 2, Color.FromArgb(211, 211, 211)),
                "ОпораШасси1"
                );
            bearingChassis1.AngleZ = -20;
            ScenePrimitives.Add(bearingChassis1);

            ScenePrimitive bearingChassis2 = new ScenePrimitive(
                new Box(new Point3D(-94, -25, -5), 2, 17, 2, Color.FromArgb(211, 211, 211)),
                "ОпораШасси2"
                );
            bearingChassis2.AngleZ = -20;
            ScenePrimitives.Add(bearingChassis2);

            ScenePrimitive bearingChassis3 = new ScenePrimitive(
                new Box(new Point3D(-90, -25, -4.5), 2, 17, 2, Color.FromArgb(211, 211, 211)),
                "ОпораШасси3"
                );
            bearingChassis3.AngleZ = 20;
            ScenePrimitives.Add(bearingChassis3);

            ScenePrimitive bearingChassis4 = new ScenePrimitive(
                new Box(new Point3D(-90, -25, 4), 2, 17, 2, Color.FromArgb(211, 211, 211)),
                "ОпораШасси4"
                );
            bearingChassis4.AngleZ = 20;
            ScenePrimitives.Add(bearingChassis4);

            ScenePrimitive chassis1 = new ScenePrimitive(
                new Cylinder(new Point3D(-92, -27, -4), 7, 2, 16, Color.FromArgb(211, 211, 211)),
                "Шасси1"
                );
            chassis1.AngleX = 90;
            ScenePrimitives.Add(chassis1);

            ScenePrimitive chassis2 = new ScenePrimitive(
                new Cylinder(new Point3D(-92, -27, 6), 7, 2, 16, Color.FromArgb(211, 211, 211)),
                "Шасси2"
                );
            chassis2.AngleX = 90;
            ScenePrimitives.Add(chassis2);

            ScenePrimitive bearingChassis5 = new ScenePrimitive(
                new Box(new Point3D(-29, -18, 0), 2, 9, 2, Color.FromArgb(211, 211, 211)),
                "ОпораШасси5"
                );
            bearingChassis5.AngleZ = -15;
            ScenePrimitives.Add(bearingChassis5);

            ScenePrimitive chassis3 = new ScenePrimitive(
                new Cylinder(new Point3D(-29, -17, 0), 4, 2, 16, Color.FromArgb(211, 211, 211)),
                "Шасси3"
                );
            chassis3.AngleX = 90;
            ScenePrimitives.Add(chassis3);

            ScenePrimitive bearingChassis6 = new ScenePrimitive(
                new Box(new Point3D(-92, -27, 5), 2, 9, 2, Color.FromArgb(211, 211, 211)),
                "ОпораШасси6"
                );
            bearingChassis6.AngleX = 90;
            ScenePrimitives.Add(bearingChassis6);

            ScenePrimitive tail1 = new ScenePrimitive(
                new Cylinder(new Point3D(-30, 3.5, 0), 6, 30, 16, Color.FromArgb(211, 211, 211)),
                "Хвост1"
                );
            tail1.AngleZ = 79;
            ScenePrimitives.Add(tail1);

            ScenePrimitive tail2 = new ScenePrimitive(
                new Hemisphere(new Point3D(-0.5, 9.5, 0), 6, 16, Color.FromArgb(211, 211, 211)),
                "Хвост2"
                );
            tail2.AngleZ = 75;
            ScenePrimitives.Add(tail2);

            ScenePrimitive auxiliary3 = new ScenePrimitive(
                new Sphere(new Point3D(-29, 0, 0), 10, 16, Color.FromArgb(211, 211, 211)),
                "Вспомогательный3"
                );
            ScenePrimitives.Add(auxiliary3);

            ScenePrimitive tailWing1 = new ScenePrimitive(
                new Box(new Point3D(-14, 7, 20), 20, 40, 2, Color.FromArgb(211, 211, 211)),
                "КрылоХвоста1"
                );
            tailWing1.AngleX = 90;
            tailWing1.AngleY = 10;
            ScenePrimitives.Add(tailWing1);

            ScenePrimitive tailWing2 = new ScenePrimitive(
                new Box(new Point3D(-12, 2, 0), 20, 26, 2, Color.FromArgb(211, 211, 211)),
                "КрылоХвоста2"
                );
            tailWing2.AngleZ = -11;
            ScenePrimitives.Add(tailWing2);

            ScenePrimitive sitPlace = new ScenePrimitive(
                new Hemisphere(new Point3D(-73.5, 10, 0), 10, 16, Color.FromArgb(0, 0, 0)),
                "Сиденье"
                );
            sitPlace.AngleX = 180;
            ScenePrimitives.Add(sitPlace);
        }
    }
}
