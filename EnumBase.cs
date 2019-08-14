using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



  public  class EnumBase
  {

    public enum AnimationMode
    {
        idle = 1,
        running = 2,
        climbing = 3,
        jumping = 4
    }

    public enum Enemies
    {

    }

    public enum Pickups
    {
        token = 1,
        coin = 2
    }

    public enum Difficulties
    {
        easy = 1,
        medium = 2,
        hard = 3
    }

    public enum GameChoice
    {
        maths = 1,
        //puzzle = 2
    }

    public enum GameLevels
    {
        level1 = 1,
        level5 = 5,
        level6 = 6,
        level7 = 7,
        level2 =2,
        level3 = 3,
        level4 = 4,
        level9 = 9,
        level10 = 10,
        levell11 = 11,
        level12 = 12
    }

    public enum Scenes
    {
        scene1 = 1,
        scene2 = 2,
        scene3 = 3,
        scene4 = 4,
        scene5 = 5,
        scene6 = 6,
        scene7 = 7,
        scene8 = 8,
        scene9 = 9,
        scene10 = 10,
        scene11 = 11,
        scene12 = 12,
        scene13 = 13,
        scene14 = 14,
        scene15 = 15,
        scene16 = 16,
        scene17 = 17,
        scene18 = 18,
        scene19 = 19,
        scene20 = 20,
        scene21 = 21,
        scene22 = 22,
        scene23 = 23,
        scene24 = 24,
        scene25 = 25,
        scene26 = 26,
        scene27 = 27,
        scene28 = 28,
        scene29 = 29,
        scene30 = 30,
        scene31 = 31,
        scene32 = 32,
        scene33 = 33,
        scene34 = 34,
        scene35 = 35,
        scene36 = 36,
    }
  }

public class LevelModel
{
    public List<string> operators;
    public int minNumber;
    public int maxNUmber;
    public int operatorIndex;
}
