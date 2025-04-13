**Mechanic 1**
Link naar code: 
Gif Van Mechanic: 

**Mechanic 2**
**Link naar code voor gif van startmenu:**

public class AnimateSprite : MonoBehaviour
{
    [SerializeField]SpriteRenderer spriteRenderer;
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }
 
    // Update is called once per frame
    void Update()
    {
        image.sprite = spriteRenderer.sprite;
    }
}

**Link naar code van startmenu naar game:**

public class MainMenu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}

Gif Van Mechanic: ![Mechanic2](https://github.com/user-attachments/assets/89638cbf-f264-4fb8-8c63-d2647fa264be)

**Mechanic 3**
Link naar code:  
Gif Van Mechanic: 

**Mechanic 4**
Link naar code: 
Gif Van Mechanic: 
