namespace Exercism_robot_simulator
{
    using System;
    using System.Collections.Generic;

    public enum Bearing
    {
        North,
        East,
        South,
        West
    }

    public class Coordinate
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override int GetHashCode()
        {
            return new[] { X, Y }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Coordinate other = obj as Coordinate;
            if (other == null)
            {
                return false;
            }

            return X == other.X && Y == other.Y;
        }
    }

    public class RobotSimulator
    {
        private readonly Dictionary<char, Action> _instructions = new Dictionary<char, Action>();

        private Dictionary<Bearing, Bearing> _turnRightMap = new Dictionary<Bearing, Bearing>
        {
            [Bearing.North] = Bearing.East,
            [Bearing.East] = Bearing.South,
            [Bearing.South] = Bearing.West,
            [Bearing.West] = Bearing.North
        };

        private Dictionary<Bearing, Bearing> _turnLeftMap = new Dictionary<Bearing, Bearing>
        {
            [Bearing.North] = Bearing.West,
            [Bearing.West] = Bearing.South,
            [Bearing.South] = Bearing.East,
            [Bearing.East] = Bearing.North
        };

        public Bearing Bearing { get; private set; }

        public Coordinate Coordinate { get; private set; }

        public RobotSimulator(Bearing bearing, Coordinate coordinate)
        {
            Bearing = bearing;

            Coordinate = coordinate;

            _instructions.Add('R', TurnRight);
            _instructions.Add('L', TurnLeft);
            _instructions.Add('A', Advance);
        }

        public void TurnRight()
        {
            Bearing = _turnRightMap[Bearing];
        }

        public void TurnLeft()
        {
            Bearing = _turnLeftMap[Bearing];
        }

        public void Advance()
        {
            switch (Bearing)
            {
                case Bearing.North:
                    Coordinate.Y++;
                    break;

                case Bearing.East:
                    Coordinate.X++;
                    break;

                case Bearing.South:
                    Coordinate.Y--;
                    break;

                case Bearing.West:
                    Coordinate.X--;
                    break;
            }
        }

        public void Simulate(string instructions)
        {
            foreach (var instruction in instructions)
            {
                if (_instructions.ContainsKey(instruction))
                {
                    _instructions[instruction]();
                }
            }
        }
    }
}
