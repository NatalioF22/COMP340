public class Goomba2DPainter : Villain
{
   

   private string[] rightLegDown = new string[10];
   private string[] leftLegDown = new string[10];

   private int moveAcrossXaxis;
   private bool movingToRight = true;

   private string[] starSprite = new string[10];



    public Goomba2DPainter() {
        rightLegDown[0] = @"     ________  ";
        rightLegDown[1] = @"    /        \ ";
        rightLegDown[2] = @"   /  \    /  \ ";
        rightLegDown[3] = @"  /   |    |   \ ";
        rightLegDown[4] = @" /  -^------^-  \ ";
        rightLegDown[5] = @"|________________| ";
        rightLegDown[6] = @" ____ /    \ ";  
        rightLegDown[7] = @"/____\      |____ ";
        rightLegDown[8] = @"       ==== /____\ ";
        rightLegDown[9] = @"                     ";

        leftLegDown[0] = @"     ________  ";
        leftLegDown[1] = @"    /        \ ";
        leftLegDown[2] = @"   /  \    /  \ ";
        leftLegDown[3] = @"  /   |    |   \ ";
        leftLegDown[4] = @" /  -^------^-  \ ";
        leftLegDown[5] = @"|________________| ";
        leftLegDown[6] = @"      /    \ ____ ";
        leftLegDown[7] = @" ____|      /____\ ";
        leftLegDown[8] = @"/____\ ====         ";
        leftLegDown[9] = @"                     ";
    }

    

    public void move()
    {
       if(movingToRight){moveAcrossXaxis+=1;}
       else{moveAcrossXaxis-=1;}
    }

    public void print()
    {
        
    }

    

    public void changeDir()
    {
        movingToRight = !movingToRight;
    }
}