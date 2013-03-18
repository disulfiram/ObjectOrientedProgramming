using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            #region Bricks
            
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                engine.AddObject(currBlock);
            }
            
            #endregion
                
            #region Ball
            
            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 1), new MatrixCoords(-1, 1));
            
            MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 1), new MatrixCoords(-1, 1));
            engine.AddObject(theBall.MeteoriteTrail());
            engine.AddObject(theBall);

            #endregion
            
            #region Racket

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            
            engine.AddObject(theRacket);

            #endregion

            //The AcademyPopcorn class contains an IndestructibleBlock 
            //class. Use it to create side and ceiling wall to the game. 
            //You can only edit the AcademyPopcornMain.cs file.
            
            #region Walls
                
            for (int i = startRow; i < WorldRows; i++)
            {
                IndestructibleBlock currBlock = new IndestructibleBlock(new MatrixCoords(i, startCol - 1));
                engine.AddObject(currBlock);
            }
            for (int i = startRow; i < WorldRows; i++)
            {
                IndestructibleBlock currBlock = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1));
                engine.AddObject(currBlock);
            }
            for (int i = startCol; i < WorldCols; i++)
            {
                IndestructibleBlock currBlock = new IndestructibleBlock(new MatrixCoords(startRow - 1, i));
                engine.AddObject(currBlock);
            }
            
            #endregion
        }
        
        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            
            Engine gameEngine = new Engine(renderer, keyboard);
            
            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };
            
            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };
            
            Initialize(gameEngine);
            
            //
            
            gameEngine.Run();
        }
    }
}