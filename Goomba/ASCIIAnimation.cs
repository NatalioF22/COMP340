public class ASCIIAnimation{
    public void StartAnimation(Villain g){
        for(int dir=0; dir<4;dir++){
            for(int i=0;i<10;i++){
                Console.Clear();
                g.move();
                g.print();
                Thread.Sleep(500);
            }
            g.changeDir();
        }
    }
}