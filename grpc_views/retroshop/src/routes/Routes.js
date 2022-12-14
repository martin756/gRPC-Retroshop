import React from 'react'
import {BrowserRouter, Routes, Route} from 'react-router-dom'
import Login from '../pages/Login'
import Signup from '../pages/Signup'
import MainMenu from '../pages/MainMenu';
import Publish from '../pages/Publish'
import BuyProduct from '../pages/BuyProduct';
import Carrito from '../pages/Carrito';
import ChargeBalance from '../pages/ChargeBalance';
import PublishedProducts from '../pages/PublishedProducts';
import EditPublication from '../pages/EditPublication';
import MyShopping from '../pages/MyShopping';
import Subasta from '../pages/Subasta';
import MonitorMenu from '../pages/MonitorMenu';
import ViewProductChanges from '../pages/ViewProductChanges';
import ViewLastBids from '../pages/ViewLastBids';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Login />}/>
        <Route path='/signup' element={<Signup />}/>
        <Route path='/mainmenu' element={<MainMenu />}/>
        <Route path='/publish' element={<Publish />}/>
        <Route path='/buyProduct' element={<BuyProduct />}/>
        <Route path='/carrito' element={<Carrito />}/>
        <Route path='/chargeBalance' element={<ChargeBalance />}/>
        <Route path='/publishedProducts' element={<PublishedProducts />}/>
        <Route path='/editPublication' element={<EditPublication />}/>
        <Route path='/myShopping' element={<MyShopping />}/>
        <Route path='/Subasta' element={<Subasta />}/>
        <Route path='/admin' element={<MonitorMenu />}/>
        <Route path='/viewProductChanges' element={<ViewProductChanges />}/>
        <Route path='/viewLastBids' element={<ViewLastBids />}/>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
