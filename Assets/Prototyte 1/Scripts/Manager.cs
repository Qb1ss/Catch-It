using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _timerText;

    private int _score;
    private int _time = 30;
    private float _gameTime;

    [SerializeField] private GameObject _button;



    private void Start()
    {
        _scoreText.text = "   " + _score.ToString();

        _time = 30;
        _timerText.text =_time.ToString() + "   ";

        Time.timeScale = 1;
        _button.SetActive(false);
    }



    private void Update()
    {
        Timer();
    }



    private void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("EditorOnly"))
        {
            _score++;
            _scoreText.text = "   " + _score.ToString();
        }
    }



    private void Timer()
    {
        _timerText.text = _time.ToString() + "   ";
        _gameTime += 1 * Time.deltaTime;

        if (_gameTime >= 1)
        {
            _time--;
            _gameTime = 0;
        }

        if (_time <= 0)
        {
            Time.timeScale = 0;
            _button.SetActive(true);
        }
    }



    public void Button_Start()
    {
        Time.timeScale = 1;
        _button.SetActive(false);

        SceneManager.LoadScene(0);
    }
}
