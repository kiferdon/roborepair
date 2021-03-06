using Utility;

namespace Items {
    public class LegItem : Item {
        public override void Init() {
            base.Init();
            frontRenderer.sprite = StatGenerator.GetSprite(Parts.LEG);
            frontRenderer.color = StatGenerator.GetColor(stats);
            int number;
            shadowSprite.sprite = ItemImageSource.GetShadowLeg(out number);
            realSprite.sprite = ItemImageSource.GetLeg(number);

        }
    }
}