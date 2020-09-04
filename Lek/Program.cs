using System;
using System.Collections.Generic;

namespace Lek
{
    class Program
    {
        static void Main(string[] args)
        {
            var onboard = new List<OnboardStepResponse>();
            onboard.Add(new OnboardStepResponse { Index = 1, Title = "Teste" });
            onboard.Add(new OnboardStepResponse { Index = 2, Title = "Teste" });
            onboard.Add(new OnboardStepResponse { Index = 3, Title = "Teste" });

            var step = new OnboardResponseViewModel() { Steps = onboard };

            foreach (var item in step.Steps)
            {
                Console.WriteLine($"{item.Index}, {item.Title}");
            }

        }
    }
}
