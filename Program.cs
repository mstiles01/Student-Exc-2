using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExc2
{
    class Program
    {
        static void Main(string[] args)
        {

        Student Larry = new Student();
        Larry.firstName = "Larry";
        Larry.lastName = "Stiles";
        Larry.slackHandle = "lstiles01";
        Larry.Cohort = 34;

        Student Loshanna = new Student();
        Loshanna.firstName = "Loshanna";
        Loshanna.lastName = "Ross";
        Loshanna.slackHandle = "lross";
        Loshanna.Cohort = 34;

        Student Tre = new Student();
        Tre.firstName = "Tre";
        Tre.lastName = "Barfeild";
        Tre.slackHandle = "trebar";
        Tre.Cohort = 35;

        Student Kristin = new Student();
        Kristin.firstName = "Kristin";
        Kristin.lastName = "Johnson";
        Kristin.slackHandle = "kjohn";
        Kristin.Cohort = 24;


        List<Student> students = new List<Student>() {
        Larry,
        Kristin,
        Loshanna,
        Tre
};

 Exercise OverlyExcited = new Exercise();
        OverlyExcited.name = "OverlyExcited";
        OverlyExcited.type = "CSharp";

        Exercise SolarSystem = new Exercise();
        SolarSystem.name = "SolarSystem";
        SolarSystem.type = "JavaScript";

        Exercise CarLot = new Exercise();
        CarLot.name = "CarLot";
        CarLot.type = "React.js";

        Exercise DynamicCards = new Exercise();
        DynamicCards.name = "DynamicCards";
        DynamicCards.type = "JavaScript";

        List<Exercise> exercises = new List<Exercise>() {
            OverlyExcited,
            SolarSystem,
            CarLot,
            DynamicCards
};

Cohort ThirtyFour = new Cohort();
        ThirtyFour.name = 34;

        Cohort ThirtyFive = new Cohort();
        ThirtyFive.name = 35;

        Cohort TwentyThree = new Cohort();
        TwentyThree.name = 24;

    List<Cohort> Cohorts = new List<Cohort>() {
        ThirtyFour,
        ThirtyFive,
        TwentyThree,

    };
        Instructor Adam = new Instructor();
        Adam.firstName = "Adam";
        Adam.lastName = "Sheaffer";
        Adam.slackHandle = "asheaffer";
        Adam.cohort = 34;
        Adam.speciality = "JavaScript";

         Instructor Andy = new Instructor();
        Adam.firstName = "Andy";
        Adam.lastName = "Colling";
        Adam.slackHandle = "Acollins";
        Adam.cohort = 35;
        Adam.speciality = "C#";

         Instructor Jenna = new Instructor();
        Adam.firstName = "Jenna";
        Adam.lastName = "Solis";
        Adam.slackHandle = "Jsolis";
        Adam.cohort = 23;
        Adam.speciality = "JavaScript";

         Instructor Bryan = new Instructor();
        Adam.firstName = "Bryan";
        Adam.lastName = "Nelson";
        Adam.slackHandle = "Bnelson";
        Adam.cohort = 35;
        Adam.speciality = "CSS";

        List<Instructor> instructors = new List<Instructor>() {
            Adam,
            Andy,
            Jenna,
            Bryan
        };

        List<Exercise> JSExercises = exercises.Where(ex => ex.type == "JavaScript").ToList();
       foreach(Exercise JavaEx in JSExercises)
        {
            Console.WriteLine(JavaEx.name);
        }



        }

        }
    }

