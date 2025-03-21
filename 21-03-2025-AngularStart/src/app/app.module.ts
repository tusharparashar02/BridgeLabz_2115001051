import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
// import { AppComponent } from './app.component';
// import { FormsModule } from '@angular/forms'; // Import FormsModule
import { AppComponent } from './app.component'; // ✅ Ensure this import is present
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule, FormsModule], // Add FormsModule
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
