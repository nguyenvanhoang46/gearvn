import { useState } from 'react'
import { MdEmail } from 'react-icons/md'
import { RiLockPasswordFill } from 'react-icons/ri'
import { useDispatch } from 'react-redux'
import { Link, useNavigate } from 'react-router-dom'
import { postLoginApi } from '../../app/services/authService'
import Category from '../catergory'
import Footer from '../Footer'
import Header from '../Header'

const Login = () => {

  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const navigate = useNavigate();
  const [error, seterror] = useState("");

  const handleLogin = async (e) => {
    e.preventDefault();
    if (!email || !password) return;
    try {
      const { accessToken, refreshToken } = await postLoginApi({ email, password });
      localStorage.setItem("token", accessToken)
      localStorage.setItem("refreshToken", refreshToken)
      navigate("/");
    } catch(e) {
      seterror("Email or password invalid")
      console.log(seterror);
    }
  }

  return (
    <>
      <div className='bg-[#f1f0f1]'>
        <Header />
        <Category />
      </div>
      <div className="container mx-auto text-center mt-10">
        <h1 className='text-[36px] font-medium '>Đăng nhập</h1>
        <div className="mt-5 flex text-center justify-center">
          <form onSubmit={handleLogin} method="">
            <div className="flex">
              <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                <MdEmail />
              </span>
              <input type="email" value={email} onChange={(e) => setEmail(e.target.value)} className='w-[270px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Email' />
            </div>
            <div className="flex  mt-5">
              <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                <RiLockPasswordFill />
              </span>
              <input type="password" value={password} onChange={(e) => setPassword(e.target.value)} className='w-[270px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Password' />
            </div>
            <div className="mt-7">
              <button type="submit" className='hover:bg-[black] bg-[#F0F0F0] uppercase hover:text-[white] cursor-pointer py-[7px] px-[14px] text-[14px] font-normal border-[1px] rounded-[4px] ' value="Đăng nhập" > Đăng nhập 		</button>
            </div>
            <div className='mt-4'>
              <Link to='/' className='text-[#428bca] hover:text-[#f45b4f]'>Quên mật khẩu? </Link>
              hoặc <Link to='/register' className='text-[#428bca] hover:text-[#f45b4f]' href="/register" title="Đăng ký">Đăng ký</Link>
            </div>
          </form>
        </div>


        <div className="mt-10">
          <Footer />
        </div>
      </div>
    </>
  )
}

export default Login