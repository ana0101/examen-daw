import { Component, OnInit } from '@angular/core';
import { MaterieService } from '../services/materie.service';
import { Observable, take } from 'rxjs';
import { Materie } from '../interfaces/materie';
import { CommonModule } from '@angular/common';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-materie',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './materie.component.html',
  styleUrl: './materie.component.scss'
})
export class MaterieComponent implements OnInit {
  constructor(private materieService: MaterieService) {}

  materii$: Observable<Materie[]> = new Observable<Materie[]>();
  postMaterieForm!: FormGroup;

  getMaterii() {
    this.materii$ = this.materieService.getMaterii();
  }

  postMaterie(form: FormGroup) {
    if (form.invalid) {
      alert("invalid form");
    }
    else {
      this.materieService.postMaterie(form.value).pipe(take(1)).subscribe(() => {
        this.getMaterii();
      })
    }
  }

  ngOnInit(): void {
    this.postMaterieForm = new FormGroup({
      denumire: new FormControl('', Validators.required)
    });

    this.getMaterii();
  }
}
