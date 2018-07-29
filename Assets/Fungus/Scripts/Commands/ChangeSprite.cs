// This code is part of the Fungus library (http://fungusgames.com) maintained by Chris Gregan (http://twitter.com/gofungus).
// It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)

using UnityEngine;

namespace Fungus
{
    /// <summary>
    /// Sets a Clickable2D component to be clickable / non-clickable.
    /// </summary>
    [CommandInfo("Sprite", 
                 "Change Sprite", 
                 "Change the sprite of a GameObject.")]
    [AddComponentMenu("")]
    public class ChangeSprite : Command
    {       
        [Tooltip("Reference to Clickable2D component on a gameobject")]
        [SerializeField] protected GameObject gameObject;

        [Tooltip("")]
        [SerializeField] protected Sprite newSprite;

        #region Public members

        public override void OnEnter()  
        {
            if (gameObject != null && newSprite != null)      
            {
                SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
                sr.sprite = newSprite;
            }
            
            Continue();
        }
        
        public override string GetSummary()
        {
            if (gameObject == null)      
            {
                return "Error: No GameObject selected";  
            }

            SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
            if (sr == null)      
            {
                return "Error: No Sprite on this GameObject";  
            }
            
            return gameObject.name;
        }
        
        public override Color GetButtonColor()
        {
            return new Color32(235, 191, 217, 255); 
        }

        #endregion
    }
        
}