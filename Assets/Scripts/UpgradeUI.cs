using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI : MonoBehaviour {
    public void Show(Vector3 position) {
        transform.position = position;
        gameObject.SetActive(true);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            Hide();
        }
    }

    public void Hide() {
        gameObject.SetActive(false);
    }

    public void OnUpgradeButtonClick() {
        BuildManager.Instance.OnTurretUpgrade();
        Hide();
    }
}