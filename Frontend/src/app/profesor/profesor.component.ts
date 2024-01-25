import { Component, KeyValueDiffers, OnInit } from '@angular/core';
import { ProfesorService } from '../services/profesor.service';
import { Observable, take } from 'rxjs';
import { Profesor } from '../interfaces/profesor';
import { CommonModule } from '@angular/common';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-profesor',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './profesor.component.html',
  styleUrl: './profesor.component.scss'
})
export class ProfesorComponent implements OnInit {
  constructor(private profesorService: ProfesorService) {}

  profesori$: Observable<Profesor[]> = new Observable<Profesor[]>();
  postProfesorForm!: FormGroup;

  getProfesori() {
    this.profesori$ = this.profesorService.getProfesori();
  }

  postProfesor(form: FormGroup) {
    if (form.invalid) {
      alert("invalid form");
    }
    else {
      this.profesorService.postProfesor(form.value).pipe(take(1)).subscribe(() => {
        this.getProfesori();
      })
    }
  }

  ngOnInit(): void {
    this.postProfesorForm = new FormGroup({
      nume: new FormControl('', Validators.required),
      tip: new FormControl('', Validators.required)
    });

    this.getProfesori();
  }
}
