// 주석 : 컴퓨터는 알아볼 수 없지만 사람만 알아볼 수 있게 표시하는 기능
// 1. // 해당 줄은 주석 처리된다. (컴퓨터는 알아볼 수 없게 된다.)
// 2. /* */ : /* ~ */ 모두 주석 처리 하라

/*
 * 학습 목표 : C# 언어로 첫 프로그래밍 작성하기 변수에 대한 이해
 * 작성일    : 2024-08-10
 * 작성자    : 황서영
 */

/*
 * 프로그래밍 + 언어
 * 프로그래밍 : 컴퓨터로 프로그램을 작동시키는 작업
 * 언어      : 두 객체 사이의 대화를 하기 위한 도구
 * 프로그래밍 언어 : 컴퓨터와 사람이 대화를 하기 위해 필요한 언어이다.
 * 
 * 사람은 기계가 하는 말을 알아들을 수 있습니까? -> X
 * 기계가 사람이 하는 말을 알아들을 수 있을까요? -> X
 * 번역기, 통역사 -> 컴파일러 : 사람과 컴퓨터 사이의 번역을 해주는 기계
 * C, C++, C#, 파이썬, 자바, 자바 스크립트, 타입 스크립트
 * .c .cpp .cs .py .jv .js .ty -> 번역기가 따로 있다.
 */

/*
 * 컴퓨터, 사람이 사용하는 언어를 표현하는 방법을 모방하려면
 * 정수는 정수 방식으로 표현한다.
 * 키워드 : 이미 의미가 정해져 있는 단어, 파란색으로 표시되어 있는 단어
 * 흰색 : 어떤 것(데이터 타입)의 이름
 * 밝은 노란색 : 함수
 * 
 * 정수는 정수 방식으로 표현
 * 실수는 실수 방식으로 표현
 * 문자는 문자 방식으로 표현
 * 
 * 정수 방식으로 사용하는 키워드 : int
 * 실수 방식으로 사용하는 키워드 : float
 * 단어 방식으로 사용하는 키워드 : char
 * 문자열 방식으로 사용하는 키워드 : string
 * 
 */

/*
 * 
 * 
 */

using System.Net.Security;

namespace CSharpStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("세계야 안녕!");
            Console.WriteLine("컴퓨터에게 정수, 실수, 문자, 문자열을 입력시켜 본다.");

            // 변수 : 변하는 수, 출력할 때 값이 다를 수 있는 형태
            // 변수의 선언
            // 키워드 해당 키워드의 이름
            // 키워드 : int(띄어 쓰기)
            // 이름 : number
            // ; : 세미콜론, 해당 코드가 끝났다라는 사실을 알려주는 키워드

            int number; // 정수를 저장할 수 있는 변수를 선언하는데 그 녀석의 이름이 number
            number = 10; // number 변수에 10을 대입하라

            // 정수형 변수로 이름을 num으로 선언해서 그 변수에 100 이라는 숫자를 넣어 보세요
            int num;
            num = 100;

            // 초기화 : 변수의 선언과 동시에 데이터를 넣는 것
            int num2 = 200;

            Console.WriteLine(number);
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(10);
            Console.WriteLine(100);
            Console.WriteLine(200);

            Console.WriteLine(10 + 100);
            int num3 = 10;
            int num4 = 20;
            // 정수의 사칙연산
            Console.WriteLine(num3 + num4);
            Console.WriteLine(num3 - num4);
            Console.WriteLine(num3 * num4);
            Console.WriteLine(num3 / num4);
            Console.WriteLine(num3 % num4);

            // 키워드를 하나 선택
            // 변수의 선언
            // 변수의 초기화
            // 변수의 사칙연산

            float f1 = 1.1f;
            float f2 = 2.2f;

            Console.WriteLine(f1 + f2);
            Console.WriteLine(f1 - f2);
            Console.WriteLine(f1 * f2);
            Console.WriteLine(f1 / f2);
            Console.WriteLine(f1 % f2);

            char c1 = 'c';
            char c2 = 'a';

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 / c2);
            Console.WriteLine(c1 % c2);
            // 문자는 사실 숫자이다.
            // A라는 숫자는 46이다.
            // 46 -> A
            // ASCII

            string s1 = "문자열";
            string s2 = "처음 만들어 보는 C# 프로그램";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine(s1 + s2);

            Console.Clear(); // 콘솔창을 비워주는 기능

            Console.WriteLine("두 수를 더해주는 프로그램입니다.");

            // 사용자의 입력을 받아서 두 수를 더하는 기능을 만들어 본다.
            // inputA 3, inputB 5 =>
            Console.Write("첫번째 숫자를 입력해 주세요 : ");
            string input; // 문자열을 저장할 수 있는 input 이라는 변수를 선언한다.
            input = Console.ReadLine();
            // 문자를 숫자(int)로 바꾸는 방법(형변환)
            int inputNumber = int.Parse(input); // 3 변환이 일어나는데, 저장을 안하고 있다.
            Console.Write("두번째 숫자를 입력해 주세요 : ");
            string inputA = Console.ReadLine();
            int inputNumber2 = int.Parse(inputA);
            Console.WriteLine("문자열의 덧셈 결과 : " + input + inputA);
            Console.WriteLine("정수의 덧셈 결과 : " + (inputNumber + inputNumber2));

            // "문자열" + 다른 숫자 => 정수의 덧셈 결과 : 숫자의 결과 값

            // 사용자의 입력을 받아서 두 수를 더하는 기능을 만들어 볼건데, 실수형 타입(float)을 받아서 프로그램을 구성해 보세요.
            Console.WriteLine("float 값 3개를 입력 받아서 더하는 프로그램");
            Console.Write("첫번째 실수를 입력해 주세요");
            string floatinput;
            floatinput = Console.ReadLine();
            float floatNumber = float.Parse(floatinput);
            Console.Write("두번째 실수를 입력해 주세요");
            string floatinput2;
            floatinput2 = Console.ReadLine();
            float floatNumber2 = float.Parse(floatinput2);
            Console.Write("세번째 실수를 입력해 주세요");
            string floatinput3;
            floatinput3 = Console.ReadLine();
            float floatNumber3 = float.Parse(floatinput3);

            Console.WriteLine("문자열의 덧셈 결과 : " + floatinput + floatinput2 + floatinput3);
            Console.WriteLine("정수의 덧셈 결과 : " + (floatNumber + floatNumber2 + floatNumber3));

            // int, float, char, string 입력을 받아서 출력해지는 것에 익숙해지기
            // 사각형의 넓이를 구하는 프로그램 만들기

            Console.Write("가로의 길이를 입력해 주세요 : ");
            string width = Console.ReadLine(); // 가로의 길이를 문자로 입력받아서 정수형으로 변환
            int widthNumber = int.Parse(width);

            Console.Write("세로의 길이를 입력해 주세요 : ");
            string height = Console.ReadLine(); // 세로의 길이를 문자로 입력받아서 정수형으로 변환
            int heightNumber = int.Parse(height);

            Console.WriteLine($"사각형의 넓이 : {width * height}"); // 문자열 중간 중괄호 안에 변수를 입력하는 방식으로 문자열을 포현 '{}'

            // 원의 넓이를 구하는 프로그램 만들기 (반지름 * 반지름 * 3.14)

            Console.Write("반지름의 길이를 입력해 주세요 : ");
            string R = Console.ReadLine();

            Console.WriteLine($"원의 넓이 : {R * R * 3.14}");





        }
    }
}
