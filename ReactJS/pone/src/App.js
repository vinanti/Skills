import Homepage from "./components/homepage";
import Loginpage from "./components/loginpage";
import Registerpage from "./components/registerpage";
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import React from "react";
import Nopage from "./components/nopage";
import Myloginidpage from "./components/myloginisdpage";
function App() {
  return (
    <BrowserRouter>
      <div>
        <Routes>
          <Route exact path="/" element={<Homepage />} />
          <Route path="/login" element={<Loginpage />} />
          <Route path="/login/:myloginid" element={<Myloginidpage />} />
          <Route path="/register" element={<Registerpage />} />
          <Route Path="*" element={<Nopage />} />
        </Routes>
      </div>
    </BrowserRouter>
  )
}

export default App;