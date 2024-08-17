using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 황서영.수업내용;

/*
 * using : 이름 공간을 사용해라
 */

namespace 황서영
{
    namespace 수업내용
    {
        /*
         * 클래스
         * 사용자 정의 데이터 유형이다. -> int, float, string, char
         * 클래스를 이용하여 객체를 생성하고 그 객체 내부에 있는 변수와 메소드를 이용하여 데이터에 접근하고 사용할 수 있는 집합체이다.
         */

        /*
         * 1. 클래스의 선언
         * class 이름 { }
         */

        class Monster
        {
            // 공격(행동)

            //체력
            //공격력
            //방어력
        }

        /*
         * 2. 클래스의 사용
         */
        class Test
        {

        }

namespace 메이플스토리
{
            class Player
            {
                public int HP;
                public int AttackPower;

                public void Show()
                {
                    Console.WriteLine($"플레이어의 체력 : {HP}");
                    Console.WriteLine($"플레이어의 공격력 : {AttackPower}");
                }

                public void Attack(Slime slime)
                {
                    slime.HP = slime.HP - AttackPower;

                    Console.WriteLine($"플레이어가 {slime.Name}을 공격했습니다!");
                    Console.WriteLine($"------------------결과-------------------");
                    Console.WriteLine($"플레이어의 공격력 : {AttackPower}으로 공격했습니다!");
                    Console.WriteLine($"슬라임의 현재 체력 : {slime.HP}");
                }

                public void Rest()
                {
                    HP = HP + 10;

                    Console.WriteLine($"플레이어가 휴식을 했습니다!");
                    Console.WriteLine($"------------------결과-------------------");
                    Console.WriteLine($"플레이어의 체력을 회복했습니다!");
                    Console.WriteLine($"플레이어의 현재 체력 : {HP}");
                }

            }

            class Slime
            {
                // 슬라임의 체력은 50입니다. 실수형, 정수형

                /*
                 * 접근 지정자
                 * 1. public : 공공의, 외부에서 전부 사용할 수 있게 하라
                 * 2. private : class 내부에서만 사용해라, 접근 지정자를 명시하지 않으면 자동으로 private 선언이 된다.
                 */

                public int HP;
                public int AttackPower;
                public string Name;
                public float MoveSpeed;

                /*
                 * 메소드 : 일련의 코드를 하나의 이름 아래 묶는 것이다.
                 * 묶인 코드를 이름을 불러주는 것만으로 실행할 수 있다.
                 * 메소드를 호출하는 것을 Call mathod (메소드 호출)
                 */

                /*
                 * (접근 지정자) (반환값) 메소드의 이름) () {}
                 * public void Show() {묶인 코드 내용들}
                 * 
                 * 
                 * 
                 * 
                 */

                int ReturnHP()
                {
                    // 반환값이 있는 함수인 경우에는 return 변수의 이름; -> 해당하는 변수 값을 변환한다.
                    return HP;
                }
                string ReturnName()
                {
                    return Name;
                }
                float ReturnMoveSpeed()
                {
                    return MoveSpeed;
                }

                // 슬라임이 공격하는 메소드를 만들어 보기
                // 슬라임이 공격할 대상이 필요하다.
                public void Attack(Player player)
                {
                    // 플레이어의 체력 - 슬라임의 공격력
                    player.HP - AttackPower;
                }

                public void Show()
                {
                    Console.WriteLine($"{Name}의 체력 : {HP}");
                    Console.WriteLine($"{Name}의 공격력 : {AttackPower}");
                    Console.WriteLine($"{Name}의 이동 속도 : {MoveSpeed}");
                }
            }

        class 초록달팽이
        {
                public int HP;
                public int AttackPower;
                public string Name;
                public float MoveSpeed;

                public void Show()
                {
                    Console.WriteLine($"{Name}의 체력 : {HP}");
                    Console.WriteLine($"{Name}의 공격력 : {AttackPower}");
                    Console.WriteLine($"{Name}의 이동속도 : {MoveSpeed}");
                }


namespace 클래스와_메소드
            {
                internal class 클래스
                {

                }
            }
