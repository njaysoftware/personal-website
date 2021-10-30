import './App.css';
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link,
} from 'react-router-dom'

function App() {
  return (
    <div className="App">
        <Router>
          <div className='nav-bar'>
            <Link to='/'>Home</Link>
            <Link to='/blog'>Blog</Link>
            <Link to='/projects'>Projects</Link>
            <button
              onClick={(e) => {
                console.log(e)
              }}
              className='hide-element'
            >Resume</button>
          </div>
          <div className='main-content'>
            <Switch>
              <Route exact path='/'>
                <div className="App-header">
                  <div className='img-wrapper'>
                    <img src='npadgett.png' className="App-logo" alt="logo" />
                  </div>
                    <h1>Hi I'm Nathaniel</h1>
                  <p className='main-paragraph'>
                    I am a passionate software developer and tech enthusiast. 
                    Most of my professional software development has been focused on building web applications using Python and Javascript but all technologies interests me. I love learning about new frameworks, languages, operating systems and just how things work weather that be a toaster oven or Linux CPU scheduling works. I hope to share with you some of what I learn on my <Link to='/blog'>blog</Link>. In my spare time you can find me exploring nature, perusing GitHub, tinkering with mechanical gadgets ⚙️, playing sports 🏈, and of course coding 👨‍💻!
                  </p>
                </div>
              </Route>
              <Route exact path='/blog'>
                <div>
                  <p>
                    Coming soon!
                  </p>
                </div>
              </Route>
              <Route exact path='/projects'>
                <div className='project-wrapper'>
                  <div className='project-wrapper-subsection'>
                    <h1>Open-Source Contributions</h1>
                    <ul>
                      <li><a href='https://github.com/njaysoftware/serverless-wsgi'>Serverless-wsgi framework plugin</a></li>
                    </ul>
                  </div>
                  <div className='project-wrapper-subsection'>
                    <h1>Personal Projects</h1>
                    <ul>
                      <li><a href='https://github.com/njaysoftware/personal-website'>Personal Website</a></li>
                    </ul>
                  </div>
                </div>
              </Route>
              <Route path='*'>
                <div>
                  <h1>404 Page</h1>
                </div>
              </Route>
            </Switch>
          </div>
          <div className='footer'>
            <p>Copyright &copy; 2021 Nathaniel Padgett. All Rights Reserved<br/><span>development by Iconstock from the Noun Project</span></p>
          </div>
        </Router>
    </div>
  );
}

export default App;
