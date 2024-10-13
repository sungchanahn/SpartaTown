using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class ParticipantManager : MonoBehaviour
{
    [SerializeField] private TMP_Text participantListText;
    [SerializeField] private TMP_Text participantNameText;
    [SerializeField] private List<string> participantList = new List<string>();
    private StringBuilder participantName = new StringBuilder();

    public void UpdateParticipant()
    {
        participantListText.text = $"참여자 목록 ({participantList.Count + 1}명)";
        participantName.Clear();
        foreach (string participant in participantList)
        {
            participantName.AppendLine($"{participant}");
        }
        participantName.AppendLine(PlayerPrefs.GetString("Name"));
        participantNameText.text = participantName.ToString();
    }
}