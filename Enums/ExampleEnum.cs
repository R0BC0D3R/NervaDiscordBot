using Discord.Interactions;

namespace NervaDiscordBot.Enums
{
    public enum ExampleEnum
    {
        First,
        Second,
        Third,
        Fourth,
        [ChoiceDisplay("Twenty First")]
        TwentyFirst
    }
}