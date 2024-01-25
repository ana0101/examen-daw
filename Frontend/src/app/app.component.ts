import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { MaterieComponent } from './materie/materie.component';
import { ProfesorComponent } from './profesor/profesor.component';
import { ProfesorMaterieComponent } from './profesor-materie/profesor-materie.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, ProfesorComponent, MaterieComponent, ProfesorMaterieComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'Frontend';
}
