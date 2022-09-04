import React, { useRef, useEffect } from 'react'
import 'bootstrap/dist/css/bootstrap.min.css'
import { useLocation, useNavigate } from 'react-router-dom';
import { jsonProducts } from './productsDemo';
import Carousel from 'react-bootstrap/Carousel'
import Header from '../components/Header';
import { CartPlusFill } from 'react-bootstrap-icons';
import Cookies from 'universal-cookie';

export default function BuyProduct(props) {
    const cookies = new Cookies()
    let carrito = cookies.get('Carrito')
    const cantidad = useRef(null)
    const navigate = useNavigate()
    const { search } = useLocation();
    let query = React.useMemo(() => new URLSearchParams(search), [search]);
    const idProduct = query.get('id')
    const product = jsonProducts.filter(p=>p.id==idProduct)[0]
    useEffect(() => {
        const script = document.createElement('script');
        script.src = "https://getbootstrap.com/docs/5.2/examples/checkout/form-validation.js";
        script.async = true;
        document.body.appendChild(script);
      return () => {
          document.body.removeChild(script);
        }
      }, []);
    const agregarAlCarrito = (event) => {
        event.preventDefault()
        debugger
        product.cantidad_disponible -= cantidad.current.value
        carrito.push(product)
        cookies.set('Carrito',carrito, {path: '/mainmenu'})
        navigate('/mainmenu')
    }
    return (
        <div>
            <Header />
            <div className="container">
                <div className="product-content product-detail">
                    <div className="row justify-content-center" style={{paddingTop: '80px',alignItems: 'center'}}>
                        <div className="col-md-5 col-sm-12 col-xs-12" style={{paddingTop: '40px'}}>
                            <Carousel style={{ width: '300px', height: '400px' }}>
                                {product.url_fotos.map((value) => (
                                    <Carousel.Item>
                                        <img
                                            className="d-block"
                                            style={{ width: '300px', height: '400px' }}
                                            src={value}
                                            alt="..."
                                        />
                                    </Carousel.Item>
                                ))}
                            </Carousel>
                        </div>
                        <div className="col-md-5 col-sm-12 col-xs-12">
                            <h2 className="name">{product.nombre}<h5>Publicado por <a href="#">Adeline</a></h5></h2>
                            <h5>{product.fecha_fabricacion.toLocaleDateString()}</h5>
                            <hr /><h3 className="price-container">${product.precio}</h3><hr />
                            <div className="description description-tabs">
                                <div className="tab-content">
                                        <strong>Descripción del producto</strong>
                                        <p>{product.descripcion}</p>
                                    <hr/>
                                    <div>
                                        Unidades en stock: 
                                        <h5>{product.cantidad_disponible}
                                        </h5>
                                    </div>
                                    <div className="row">
                                        <div className="col-sm-12 col-md-6 col-lg-6">
                                        <form onSubmit={(event)=>{agregarAlCarrito(event)}} className="needs-validation" noValidate>
                                            <div className="col-12">
                                                <label className="form-label"></label>
                                                <input ref={cantidad} type="number" className='form-control' required placeholder='Cantidad' min="1" max={product.cantidad_disponible}/>
                                                <div className="invalid-feedback"></div>
                                            </div>
                                            <br></br>
                                            <button type="submit" className="btn btn-success btn-lg"><CartPlusFill/> Agregar al carrito</button>
                                        </form>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            {/*<div className='container'>
                <div className="row g-5 mt-4 justify-content-center">
                    <div className="col-md-2 col-lg-3 row g-3 justify-content-center">
                        <h4 className="text-center mb-3">Comprar producto</h4>
                        <Carousel  style={{width: '300px', height: '400px'}}>
                        {product.url_fotos.map((value)=>(
                            <Carousel.Item>
                            <img
                                className="d-block"
                                style={{width:'300px',height: '400px'}}
                                src={value}
                                alt="..."
                            />
                            </Carousel.Item>
                        ))}
                        </Carousel>
                    </div>
                    <div className="w-50 mt-4">
                        <h5 className="form-label">Nombre del producto: <i className='fw-normal'>{product.nombre}</i></h5>
                        <h5 className="mt-4 form-label">Descripción: <i className='fw-normal'>{product.descripcion}</i></h5>
                        <h5 className="mt-4 form-label">Cantidad disponible: <i className='fw-normal'>{product.cantidad_disponible}</i></h5>
                        <h5 className="mt-4 form-label">Fecha de fabricación: <i className='fw-normal'>{product.fecha_fabricacion.toLocaleString()}</i></h5>
                    </div>
                </div>
            </div>*/}
        </div>
  )
}