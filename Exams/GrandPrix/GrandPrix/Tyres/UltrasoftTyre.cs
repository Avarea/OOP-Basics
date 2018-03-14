﻿using System;

public class UltrasoftTyre : Tyre
{
    private double grip;
    private double degradation;


    public UltrasoftTyre(double hardness, double grip) : base(hardness)
    {
        this.Name = "Ultrasoft";
        this.Grip = grip;
    }

    public double Grip
    {
        get { return grip; }
        set { grip = value; }
    }

    public override double Degradation
    {
        get => this.degradation;
        protected set
        {
            if (value < 30)
            {
                throw new ArgumentException("Blown Tyre");
            }
            this.degradation = value;
        }
    }

    public override void ReduceDegradation()
    {
        var sum = this.Hardness + this.Grip;
        this.Degradation -= sum;
    }
}


