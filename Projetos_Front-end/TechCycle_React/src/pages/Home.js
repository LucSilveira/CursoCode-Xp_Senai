import React, {Component} from 'react';
import CabecalhoUser from '../componentes/CabecalhoUser';
import Rodape from '../componentes/Rodape';
import '../assets/css/home.css';
import {Link} from 'react-router-dom'
import { parseJwt } from '../services/auth';
import { api, apiForm } from '../services/api';

class Home extends Component{
    constructor(props){
      super(props);
      this.state = {
        idUser : parseJwt().IdUsuario,
        listaAnuncios : [],
        idAnuncio : '',
        idProduto : {
          nomeProduto : '',
          descricao : ''
        },
        preco : '',
        dataExpiracao : '',
      }
      this.buscarAnuncio = this.buscarAnuncio.bind(this)
    }

    buscarAnuncio(){
      api.get('/anuncio')
      .then(response => this.setState({ listaAnuncios : response.data }))
      .catch((erro) => console.log(erro))
    }

    cadastrarInteresse(){
      apiForm.post('/interesse',{
          body : JSON.stringify({
            idUsuarioInteressado : parseInt(this.state.idUser),
            idAnuncio : this.state.idAnuncio
          }),
          headers : {
            'Content-type' : 'application/json'
          }
        })
        .then(response => response.data)
        .catch(error => console.log('Não foi possível cadastrar:' + error)) 
    }

    passarAnuncio(event){
      localStorage.setItem('idAnuncio', event.target.anuncio.idAnuncio)
    }

    redirec(){
      this.context.router.push({
        pathname: '/descricao',
        state: {idAnuncio: this.state.idAnuncio}  
      })
    }

    componentDidMount(){
      this.buscarAnuncio()
    }

  render(){
    return (
      <div className="App">
        <CabecalhoUser/>
          <main className="home_main">
          <h1>Vitrine de Anúncios</h1>
          <hr/>
          <section className="home_linhaCard">
            {
              this.state.listaAnuncios.map(function(anuncio){
                return(
                    <div className="home_card" key={anuncio.idAnuncio} value={anuncio.idAnuncio}>
                      <div className="home_img">
                      <img src={'http://localhost:5000/Resources/Anuncio/' + anuncio.fotosAnuncio[0].fotoDoAnuncio} alt="Foto referente ao produto do anúncio"/>
                      </div>
                      <div className="home_linha">
                          <div>
                              <h3 className="home_nomeProduto">{anuncio.idProdutoNavigation.nomeProduto}</h3>
                          </div>
                          <div>
                              <h3 className="home_preco">R${anuncio.preco},00</h3>
                          </div>
                      </div>
                      <div className="home_texto">
                          <p>{anuncio.idProdutoNavigation.descricao}</p>
                              <p className="dataExpiracao_home">Data de expiração: {anuncio.dataExpiracao}</p>
                      </div>
                      <div className="home_linha">
                          <button className="home_btn"><Link to={{
                                                                pathname: '/descricao',
                                                                state: {idAnuncio: anuncio.idAnuncio  }
                                                                }}>Detalhes</Link></button>
                          <div className="home_coracao"><i className="far fa-heart" onClick={e => {this.cadastrarInteresse()}}></i></div>
                      </div>
                  </div>          
                )
              }, this)
            }
          </section>
      </main>
        <Rodape/>
    </div>
  );
}

}
export default Home;