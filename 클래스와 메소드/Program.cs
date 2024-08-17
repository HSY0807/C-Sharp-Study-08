using System.Drawing;
using 메이플스토리;

namespace 클래스와_메소드
{
    internal class Program
    {
        static void PlayerTurn(Player player, Slime slime)
        {
            Console.WriteLine("1. 공격한다.");
            Console.WriteLine("2. 휴식한다.");
            Console.WriteLine("유저의 행동을 입력해 주세요");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                player.Attack(slime);
            }
            else if (userInput == 2)
            {
                player.Rest();
            }
        }

            static void Main(string[] args)
        {
            네임스페이스 ns = new 네임스페이스();
            ns.Show();

            /*
             * 클래스 사용하는 방법
             * (이름 공간.Slime) (클래스의 이름 변수) = new 메이플스토리.Slime();
             */

            메이플스토리.Slime slime = new 메이플스토리.Slime();
            slime.Name = "슬라임";
            slime.HP = 50;
            slime.AttackPower = 5;
            slime.MoveSpeed = 2.2f;
            slime.Show();

            메이플스토리.Player player = new 메이플스토리.Player();
            player.HP - 100;
            player.AttackPower - 10;

            slime.Attack(player);
            slime.BeAttacked(player.AttackPower);
            slime.Show();

            //player.Show();

            while(true) // 무한 반복문
            {
                Console.WriteLine("1. 공격한다.");
                Console.WriteLine("2. 휴식한다.");
                Console.WriteLine("유저의 행동을 입력해 주세요");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    player.Attack(slime);
                }
                else if (userInput == 2)
                {
                    player.Rest();
                }

        }
    }
}
