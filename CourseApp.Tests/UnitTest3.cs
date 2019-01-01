// using System;
// using System.Collections.Generic;
// using System.Text;
// using Xunit;

// namespace CourseApp.Tests
// {
//     public class UnitTest3
//     {
//         [Fact]
//         public void Test8()
//         {
//             Wolf one = new Wolf();
//             var name = one.WolfName;
//             var age = one.Age;
//             var color = one.Color;
//             Assert.Equal("Неизвестное", name);
//             Assert.Equal(2, age);
//             Assert.Equal("Прозрачный", color);
//         }
//         [Fact]
//         public void Test9()
//         {
//             Wolf two = new Wolf("Дикий", "Чёрный");
//             var name = two.WolfName;
//             var age = two.Age;
//             var color = two.Color;
//             Assert.Equal("Дикий", name);
//             Assert.Equal(3, age);
//             Assert.Equal("Чёрный", color);
//         }
//         [Fact]
//         public void Test10()
//         {
//             Wolf three = new Wolf("Третий", "Белый", 3);
//             var name = three.WolfName;
//             var age = three.Age;
//             var color = three.Color;
//             Assert.Equal("Третий", name);
//             Assert.Equal(3, age);
//             Assert.Equal("Белый", color);
//         }

//         [Fact]
//         public void Test11()
//         {
//             Wolf one = new Wolf();
//             var age = one.Age;
//             one.Age = -1;
//             Assert.Equal(2, age);
//         }



//         [Fact]
//         public void Test12()
//         {
//             string wolf = @"   ,     ,
//                         |\---/|
//                        /  , , |
//                   __.-'|  / \ /
//          __ ___.-'        ._O|
//       .-'  '        :      _/
//      / ,    .        .     |
//     :  ;    :        :   _/
//     |  |   .'     __:   /
//     |  :   /'----'| \  |
//     \  |\  |      | /| |
//      '.'| /       || \ |
//      | /|.'       '.l \\_
//      || ||             '-'
//      '-''-'";

//             Assert.Equal(@"   ,     ,
//                         |\---/|
//                        /  , , |
//                   __.-'|  / \ /
//          __ ___.-'        ._O|
//       .-'  '        :      _/
//      / ,    .        .     |
//     :  ;    :        :   _/
//     |  |   .'     __:   /
//     |  :   /'----'| \  |
//     \  |\  |      | /| |
//      '.'| /       || \ |
//      | /|.'       '.l \\_
//      || ||             '-'
//      '-''-'", wolf);

//         }
//     }
// }
