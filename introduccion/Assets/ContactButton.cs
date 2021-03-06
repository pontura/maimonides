﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContactButton : MonoBehaviour {

	// agregar el apellido, foto
	// va a abrir el perfil

	public Text field;
	public Image image;

	Popup popup;
	ContactData data;

	public void Init (ContactData data, Popup popup) {
		this.data = data;
		this.popup = popup;
		field.text = data.firstName + " " + data.lastName;
		image.sprite = data.photo;
		GetComponent<Image>().color = new Color ((float)(Random.Range(0,100))/100, (float)(Random.Range(0,100))/100,(float)(Random.Range(0,100))/100);
	}

	public void OnButtonClick () {
		popup.Init (data);
	}
}
