import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Profesor } from '../interfaces/profesor';
import { ProfesorDto } from '../interfaces/profesor-dto';

@Injectable({
  providedIn: 'root'
})
export class ProfesorService {

  constructor(private http: HttpClient) { }

  readonly APIUrl = "https://localhost:7108/api/Profesori";
  
  getProfesori(): Observable<Profesor[]> {
    const url = `${this.APIUrl}`;
    return this.http.get<Profesor[]>(url);
  }

  postProfesor(profesorDto: ProfesorDto): Observable<Profesor> {
    const url = `${this.APIUrl}`;
    return this.http.post<Profesor>(url, profesorDto);
  }
}
