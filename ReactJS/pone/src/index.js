import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import Homepage from './components/homepage';
import Loginpage from './components/loginpage';
import Registerpage from './components/registerpage';
import reportWebVitals from './reportWebVitals';
import App from './App';

import { BrowserRouter, Routes, Route } from 'react-router-dom'

const myroute = (
  <BrowserRouter>
    <div>
      <Routes>
        <Route exact path="/" element={<Homepage />} />
        <Route path="/login" element={<Loginpage />} />
        <Route path="/register" element={<Registerpage />} />
        <Route path="/app" element={<App />} />
      </Routes>
    </div>
  </BrowserRouter>
)

ReactDOM.render(
  <App />,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();