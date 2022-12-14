import React from 'react'

const Footer = () => {
  return (
    <>
      <div className="grid grid-cols-12">
        <div className="col-span-4">
          <h3>Công ty TNHH Thương Mại GEARVN </h3>
          <h3 className="">	Email: cskh@gearvn.com</h3>
          <div className="text-sm">
            <p>HỆ THỐNG TỔNG ĐÀI MIỄN PHÍ: <span>(Làm việc từ 08h00 - 21h00)</span></p>
            <table className='w-[296px] '>
              <tr className=''>
								<td >Gọi mua hàng</td>
								<td className='mt-10' ><strong>1800 6975</strong></td>
							</tr>
							<tr className=''>
								<td >Hỗ trợ khách hàng</td>
								<td ><strong>1800 6173</strong></td>
							</tr>
						</table>
          </div>
          <div className="text-[#0655a6] text-[16px] font-bold ">
            <a href="client/src/components/Footer/index">Chính sách bảo hành</a>
            <br />
            <a href="client/src/components/Footer/index">Chính sách thanh toán</a>
            <br />
            <a href="client/src/components/Footer/index">Chính sách giao hàng</a>
            <br />
            <a href="client/src/components/Footer/index">Chính sách bảo mật</a>
          </div>
          <div className="">
          <img className='max-w-[300px]' src="https://theme.hstatic.net/1000026716/1000440777/14/20150827110756-dathongbao.png" />
          </div>
        </div>
        <div className="col-span-5">
          <a href='client/src/components/Footer/index' className='uppercase text-[16px] text-[#428bca] '><b>HỆ THỐNG CỬA HÀNG:</b></a>
          <ul className='text-[16px] '>
            <h4 className=''><b>SHOWROOM HCM</b> <span>(Làm việc từ 8h00 - 21h00)</span></h4>
            <li>- Địa chỉ 1: 78-80-82 Hoàng Hoa Thám, Phường 12, Quận Tân Bình.</li>
            <li>- Địa chỉ 2: 905 Kha Vạn Cân, Phường Linh Tây, Thành phố Thủ Đức.</li>
            <li>- Địa chỉ 3: 1081 - 1083 Trần Hưng Đạo, Phường 5, Quận 5.</li>
            <li>- Địa chỉ 4: 415 An Dương Vương, Phường 10, Quận 6.</li>
            <h4 className=''><b>SHOWROOM HN</b> <span>(Làm việc từ 8h00 - 21h00)</span></h4>
            <li>- Địa chỉ 1: 78-80-82 Hoàng Hoa Thám, Phường 12, Quận Tân Bình.</li>
            <li>- Địa chỉ 2: 905 Kha Vạn Cân, Phường Linh Tây, Thành phố Thủ Đức.</li>
            <li>- Địa chỉ 3: 1081 - 1083 Trần Hưng Đạo, Phường 5, Quận 5.</li>
            <li>- Địa chỉ 4: 415 An Dương Vương, Phường 10, Quận 6.</li>
          </ul>
          <a href='client/src/components/Footer/index' className='uppercase text-[16px] text-[#428bca] '><b>TRUNG TÂM BẢO HÀNH:</b></a>
          <p>- Địa chỉ : 436A/71 đường 3/2, Phường 12, Quận 10, Hồ Chí Minh.</p>
          <ul className='text-[14px] '>
            <li>- Công ty TNHH Thương Mại Gearvn</li>
            <li>- GPKD số 0316517394 do Sở KH và ĐT TP Hồ Chí Minh cấp ngày 01/10/2020</li>
            <li>- GĐ/Sở hữu website: Nguyễn Thế Anh</li>
          </ul>
          <a className='justify-center flex' href="https://www.dmca.com/Protection/Status.aspx?ID=65147526-7602-46be-9047-e8c33f9fcbd3&amp;refurl=https://gearvn.com/">
             <img src="https://images.dmca.com/Badges/dmca_protected_sml_120m.png?ID=65147526-7602-46be-9047-e8c33f9fcbd3" alt="DMCA.com Protection Status" />
          </a>
        </div>
        <div className="col-span-3">
          <h3 className='font-bold text-[16px] uppercase'>Fanpage</h3>
        </div>
      </div>
    </>
  )
}

export default Footer
