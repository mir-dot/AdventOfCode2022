using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Solutions
{
    class Day2
    {
        public void determineWinnerScore(string[] lines)
        {
            int counter = 0;
            int correctCounter = 0;
            foreach (string line in lines)
            {
                string[] gameOpponent = line.Split(' ');
                int gamePoints = 0; 
                int shapePoints = 0;
                int correctShapePoints = 0;
                int correctGamePoints = 0;

                switch (gameOpponent[1])
                {
                    case "X":
                        shapePoints = 1;
                        correctGamePoints = 0;
                        switch (gameOpponent[0])
                        {
                            case "A":
                                gamePoints = 3;
                                correctShapePoints = 3;
                                break;
                            case "B":
                                gamePoints = 0;
                                correctShapePoints = 1;
                                break;
                            case "C":
                                gamePoints = 6;
                                correctShapePoints = 2;
                                break;
                        }
                        break;
                    case "Y":
                        shapePoints = 2;
                        correctGamePoints = 3;
                        switch (gameOpponent[0])
                        {
                            case "A":
                                gamePoints = 6;
                                correctShapePoints = 1;
                                break;
                            case "B":
                                gamePoints = 3;
                                correctShapePoints = 2;
                                break;
                            case "C":
                                gamePoints = 0;
                                correctShapePoints = 3;
                                break;
                        }
                        break;
                    case "Z":
                        shapePoints = 3;
                        correctGamePoints = 6;
                        switch (gameOpponent[0])
                        {
                            case "A":
                                gamePoints = 0;
                                correctShapePoints = 2;
                                break;
                            case "B":
                                gamePoints = 6;
                                correctShapePoints = 3;
                                break;
                            case "C":
                                gamePoints = 3;
                                correctShapePoints = 1;
                                break;
                        }
                        break;
                }

                counter += shapePoints + gamePoints;
                correctCounter += correctShapePoints + correctGamePoints;
            }

            System.Console.WriteLine("Total score assuming 2nd column is Shapes: {0} ", counter);
            System.Console.WriteLine("Total score assuming 2nd column based on game status: {0} ", correctCounter);
            System.Console.ReadLine();
        }
    }

}
