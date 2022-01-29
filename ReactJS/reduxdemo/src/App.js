import {BrowserRouter, Routes, Route} from 'react-router-dom'
import Footer from './component/footer';
import Header from './component/header';

import Body from './container/body'

function App() {
  return (
    <BrowserRouter>
        <Header />
        <Route exact path="/" element={<Body />} />
        <Footer />
    </BrowserRouter>
  );
}

export default App;
