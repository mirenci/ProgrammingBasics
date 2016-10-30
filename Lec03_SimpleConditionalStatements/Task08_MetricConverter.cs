using System;

class MetricConverter
{

    static void Main()
    {
        /*
            1 meter (m)	1000 millimeters (mm)
            1 meter (m)	100 centimeters (cm)
            1 meter (m)	0.000621371192 miles (mi)
            1 meter (m)	39.3700787 inches (in)
            1 meter (m)	0.001 kilometers (km)
            1 meter (m)	3.2808399 feet (ft)
            1 meter (m)	1.0936133 yards (yd)
         */
        const double meterToMillimeter = 1000;
        const double meterToCentimeters = 100;
        const double meterToMiles = 0.000621371192;
        const double meterToInches = 39.3700787;
        const double meterToKilometer = 0.001;
        const double meterToFeet = 3.2808399;
        const double meterToYards = 1.0936133;

        double value = double.Parse(Console.ReadLine());
        string unitFrom = Console.ReadLine();
        string unitTo = Console.ReadLine();

        double valueInMeters = 0;
        double result = 0;

        //Unit To Meters
        if (unitFrom == "m")
        {
            valueInMeters = value;
        }
        else if (unitFrom == "mm")
        {
            valueInMeters = value / meterToMillimeter;
        }
        else if (unitFrom == "cm")
        {
            valueInMeters = value / meterToCentimeters;
        }
        else if (unitFrom == "mi")
        {
            valueInMeters = value / meterToMiles;
        }
        else if (unitFrom == "in")
        {
            valueInMeters = value / meterToInches;
        }
        else if (unitFrom == "km")
        {
            valueInMeters = value / meterToKilometer;
        }
        else if (unitFrom == "ft")
        {
            valueInMeters = value / meterToFeet;
        }
        else if (unitFrom == "yd")
        {
            valueInMeters = value / meterToYards;
        }

        //Meters To Unit
        if (unitTo == "m")
        {
            result = valueInMeters;
        }
        if (unitTo == "mm")
        {
            result = valueInMeters * meterToMillimeter;
        }
        else if (unitTo == "cm")
        {
            result = valueInMeters * meterToCentimeters;
        }
        else if (unitTo == "mi")
        {
            result = valueInMeters * meterToMiles;
        }
        else if (unitTo == "in")
        {
            result = valueInMeters * meterToInches;
        }
        else if (unitTo == "km")
        {
            result = valueInMeters * meterToKilometer;
        }
        else if (unitTo == "ft")
        {
            result = valueInMeters * meterToFeet;
        }
        else if (unitTo == "yd")
        {
            result = valueInMeters * meterToYards;
        }

        Console.WriteLine("{0} {1}", result, unitTo);
    }
}
