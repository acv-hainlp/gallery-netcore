// src/app/auth/auth.service.ts

import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import 'rxjs/add/operator/filter';
import * as auth0 from 'auth0-js';

@Injectable()
export class AuthService {

  auth0 = new auth0.WebAuth({
    clientID: 'zjiBkHY3sYHEHL1d5RpiX5RsqA0w7IHU',
    domain: 'liminstudio.auth0.com',
    responseType: 'token id_token',
    audience: 'https://liminstudio.auth0.com/userinfo',
    redirectUri: 'http://localhost:5000/callback',      
    scope: 'openid'
  });

  constructor(public router: Router) {}

  public login(): void {
    this.auth0.authorize();
  }

}