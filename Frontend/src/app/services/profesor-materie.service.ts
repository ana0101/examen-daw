import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ProfesorMaterie } from '../interfaces/profesor-materie';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProfesorMaterieService {

  constructor(private http: HttpClient) { }

  readonly APIUrl = "https://localhost:7108/api/ProfesoriMaterii";

  getProfesoriMaterii(): Observable<ProfesorMaterie[]> {
    const url = `${this.APIUrl}`;
    return this.http.get<ProfesorMaterie[]>(url);
  }

  postProfesorMaterie(profesorMaterie: ProfesorMaterie): Observable<ProfesorMaterie> {
    const url = `${this.APIUrl}`;
    return this.http.post<ProfesorMaterie>(url, profesorMaterie);
  }
}
