// import { Component } from '@angular/core';
import { Component, OnInit } from '@angular/core'; 

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title: string = ''; // For UC1
  imgUrl: string = "https://www.bridgelabz.com/assets/images/BridgeLabz%20New%20Logo.svg"; 
  bridgeLabzUrl: string = "https://www.bridgelabz.com"; // For UC3
  userName: string = ''; // For UC4 & UC5
  errorMessage: string = ''; // For UC5

  ngOnInit(): void {
    this.title = "Hello from BridgeLabz"; // UC1: Initialize title when component is loaded
  }

  openBridgeLabz(): void {
    window.open(this.bridgeLabzUrl, "_blank"); // UC3: Open BridgeLabz in new tab
  }

  validateUser(): void {
    const regex = /^[A-Z][a-zA-Z]{2,}$/; // UC5: Validation for user input
    if (!regex.test(this.userName)) {
      this.errorMessage = "Invalid name! Must start with a capital letter and be at least 3 letters.";
    } else {
      this.errorMessage = "";
    }
  }
}