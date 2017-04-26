import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { AutoCompleteModule } from 'primeng/components/autocomplete/autocomplete';


import { AppComponent } from './app.component';
import { EdytujOsobeComponent } from './osoba/edytuj-osobe.component';

@NgModule({
  declarations: [
    AppComponent,
    EdytujOsobeComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    HttpModule,
    AutoCompleteModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
