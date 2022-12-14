import React from 'react'
import {Link} from 'react-router-dom'
const Logo = () => {
  return (
    <div>
      <Link to='/'>
        <img src="//theme.hstatic.net/1000026716/1000440777/14/logo.svg?v=30135" alt="" className='w-[170px]'/>
      </Link>
    </div>
  )
}

export default Logo
