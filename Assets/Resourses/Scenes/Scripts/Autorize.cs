using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Autorize : MonoBehaviour
{
    [SerializeField] TMP_InputField inputUser;
    [SerializeField] TMP_InputField inputGroup;
    public void Autorization()
    {
        string user = inputUser.text;
        string group = inputGroup.text;
        SceneManager.LoadScene(8);
        Debug.Log(user);
        Debug.Log(group);
    }
    //здесь должно быть создание json файла пользователя где на остальных сценах он будет заполняться результатами заданий
}

//Потом пригодится
/*
 * Чтобы ограничить ввод в input Unity только допустимыми символами, 
 * можно использовать обработчик событий onValidateInput компонента InputField.
 * Этот обработчик вызывается при каждом вводе символа, и позволяет отфильтровать ввод.
 * Вот пример кода на C#, который реализует такое ограничение:
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class InputFieldValidator : MonoBehaviour
{
    public InputField inputField;
    public string allowedCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 "; // Допустимые символы (пример)

    void Start()
    {
        inputField.onValidateInput += ValidateInput;
    }

    char ValidateInput(string text, int charIndex, char addedChar)
    {
        if (allowedCharacters.IndexOf(addedChar) != -1)
        {
            return addedChar;
        }
        return '\0';
    }
}
*/

