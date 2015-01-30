﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Physea
{
    public class Cube : PhysObj
    {
        public double Mass { get; set; }
        public double Volume { get; set; }
        public double Density
        {
            get
            {
                return Mass / Volume;
            }
        }
        public Vector2D Velocity { get; set; }
        public Vector2D TotalForce { get; set; }

        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }

        public double PositionX { get; set; }
        public double PositionY { get; set; }

        public List<Force> Forces { get; set; }

        public Cube (double len, double mass, double xpos, double ypos)
        {
            this.Width = len;
            this.Height = len;
            this.Depth = len;
            this.Mass = mass;
            this.Volume = this.Width * this.Height * this.Depth;

            this.PositionX = xpos;
            this.PositionY = ypos;

            this.Forces = new List<Force>();
            this.TotalForce = new Vector2D(0, 0);
            this.Velocity = new Vector2D(0, 0);
        }

        public void CalculateForces(double t)
        {
            this.TotalForce.X = 0; this.TotalForce.Y = 0;

            foreach (Force f in this.Forces) // merge all applied forces into one vector, then use it as acceleration
            {
                if (f.GetType() == typeof(Gravity))
                {
                    this.TotalForce += ((f.Direction * f.Amplitude) * this.Mass); // G in Newtons
                }
                else if (f.GetType() == typeof(AirResistance))
                {
                    var ar = (f as AirResistance);
                    ar.DragCoefficient = 1.05;
                    ar.ObjectVelocity = this.Velocity.Length;
                    ar.Direction = -(this.TotalForce.Normalized());
                    ar.Area = this.Volume / this.Depth;
                    this.TotalForce += (f.Direction * f.Amplitude); // other in Newtons
                }
                else
                {
                    this.TotalForce += (f.Direction * f.Amplitude); // other in Newtons
                }
            }


            // http://en.wikipedia.org/wiki/Equations_for_a_falling_body
            // this.PositionY = 0.5 * (TotalForce.Y / Mass) * t * t; // works for fall

            this.PositionX += (((TotalForce.X / Mass) * t / 2) + this.Velocity.X);
            this.PositionY += (((TotalForce.Y / Mass) * t / 2) + this.Velocity.Y);
            this.Velocity += this.TotalForce / this.Mass;
        }
    }
}
