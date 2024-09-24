using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float totalhp = 10;
    public void TakeDamage(int damage){
        totalhp-=damage;
        healthBar.fillAmount = totalhp/10f;
    }
}
