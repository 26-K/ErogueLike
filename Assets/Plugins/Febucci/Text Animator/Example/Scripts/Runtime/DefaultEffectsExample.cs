using UnityEngine;

namespace Febucci.UI.Examples
{
    [AddComponentMenu("")]
    public class DefaultEffectsExample : MonoBehaviour
    {
        public TextAnimatorPlayer textAnimatorPlayer;

        private void Awake()
        {
            UnityEngine.Assertions.Assert.IsNotNull(textAnimatorPlayer, $"Text Animator Player component is null in {gameObject.name}");
        }

        private void Start()
        {
            const char quote = '"';
            //builds the text with all the default tags
            string builtText = "きゃっ。ぁっ……にるくくん、</color>." +
                $"\nこれ、射精……ん、凄い……" +
                $"\n<bounce>どぴゅっ、どぴゅっ</bounce>て……."+
                $"\nこんな風に出るんですね……" +
            $"大丈夫ですよ。このまま出し切っちゃってください";

            //for (int i = 0; i < TAnimTags.defaultBehaviors.Length; i++)
            //{
            //    builtText += EffectsTesting.AddEffect(TAnimTags.defaultBehaviors[i]);
            //}

            //builtText += $"\n\n<b>Effects that animate letters while they appear on screen are called {quote}<color=red>Appearances</color>{quote} and the default tags are</b>: ";

            //for (int i = 0; i < TAnimTags.defaultAppearances.Length; i++)
            //{
            //    builtText += EffectsTesting.AddAppearanceEffect(TAnimTags.defaultAppearances[i]);
            //}

            //shows the text dynamically (typewriter like)
            textAnimatorPlayer.ShowText(builtText);
            //これ、射精……ん、凄い……どぴゅっ、どぴゅって……こんな風に出るんですね……。大丈夫ですよ。このまま出し切っちゃってください
        }
    }

}