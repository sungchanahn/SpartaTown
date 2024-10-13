using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMPro;
using UnityEngine;

public class ParticipantManager : MonoBehaviour
{
    public TMP_Text[] Participant;
    [SerializeField] private TMP_Text participantListText;
    [SerializeField] private TMP_Text participantNameText;
    private StringBuilder participantName = new StringBuilder();

    public void UpdateParticipant()
    {
        Participant = GameManager.Instance.SpawnPoint.GetComponentsInChildren<TMP_Text>();
    }

    public void UpdateParticipantList()
    {
        UpdateParticipant();
        participantListText.text = $"참여자 목록 ({Participant.GetLength(0)}명)";
        participantName.Clear();
        foreach (TMP_Text participant in Participant)
        {
            participantName.AppendLine(participant.text);
        }
        participantNameText.text = participantName.ToString();
    }
}