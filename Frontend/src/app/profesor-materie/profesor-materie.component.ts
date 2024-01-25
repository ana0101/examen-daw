import { Component, OnInit } from '@angular/core';
import { ProfesorMaterieService } from '../services/profesor-materie.service';
import { Observable, take } from 'rxjs';
import { ProfesorMaterie } from '../interfaces/profesor-materie';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-profesor-materie',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './profesor-materie.component.html',
  styleUrl: './profesor-materie.component.scss'
})
export class ProfesorMaterieComponent implements OnInit {

  constructor(private profesorMaterieService: ProfesorMaterieService) {}

  profesoriMaterii$: Observable<ProfesorMaterie[]> = new Observable<ProfesorMaterie[]>();
  postProfesorMaterieForm!: FormGroup;

  getProfesoriMaterii() {
    this.profesoriMaterii$ = this.profesorMaterieService.getProfesoriMaterii();
  }

  postProfesorMaterie(form: FormGroup) {
    if (form.invalid) {
      alert("invalid form");
    }
    else {
      this.profesorMaterieService.postProfesorMaterie(form.value).pipe(take(1)).subscribe(() => {
        this.getProfesoriMaterii();
      })
    }
  }

  ngOnInit(): void {
    this.postProfesorMaterieForm = new FormGroup({
      profesorId: new FormControl('', Validators.required),
      materieId: new FormControl('', Validators.required)
    });

    this.getProfesoriMaterii();
  }
}
